namespace Battleships
{
    using Battleships.ENum;
    using Battleships.Models;
    using System;
    using System.Collections.Generic;
    using System.Drawing;
    using System.Linq;
    using System.Windows.Forms;

    public partial class GameBoard : Form
    {
        // Constructor
        public GameBoard()
        {
            InitializeComponent();

            for (int rowNumber = 1; rowNumber < 11; rowNumber++)
            {
                for (int columnNumber = 1; columnNumber < 11; columnNumber++)
                {
                    string columnLetter = DetermineColumnLetter(columnNumber);
                    Cell cell = new Cell();
                    cell.Name = columnLetter + rowNumber; //Adds and then concatenates the stings together to give the name
                    cell.RowNumber = rowNumber;
                    cell.Column = columnLetter;
                    cell.Status = CellStatus.Empty;
                    this.cells.Add(cell);
                    //this.cells.Add(cell.Name, cell); //B4, and it's a cell - Would have used this line if using a dictionary to store all the cells on the game board.
                }
            }
        }

        // Key is string, Values are the Cells A4 for example
        //private Dictionary<string, Cell> cells = new Dictionary<string, Cell>(); considered using a dictionary, but used a list to enable wider selection criteria options

        private List<Cell> cells = new List<Cell>();
        private List<Cell> battleship = new List<Cell>(); 
        private List<Cell> destroyerOne = new List<Cell>(); // need to differenciate between destroyer one and two so the user is informed when one destroyer is sunk
        private List<Cell> destroyerTwo = new List<Cell>(); // If more than 2 destroyers were required, then could have an array of destroyers rather than separate variables.

        private string DetermineColumnLetter(int columnNumber)
        {
            ColumnLetter columnLetter = (ColumnLetter)columnNumber;
            return columnLetter.ToString();
        }

        private void btnStartGame_Click(object sender, EventArgs e)
        {
            btnFire.Enabled = true;
            bool shipCreated = false;
            var random = new Random(); // ensure only one random object is used throughout the method. If multiple random objects were created in a tight loop, the same random numbers could be generated each time :-/

            do
            {
                this.battleship.Clear();    // resetting the squares
                this.destroyerOne.Clear();
                this.destroyerTwo.Clear();

                // acts as an initiliser to clear the memory of all states
                foreach (Cell cell in cells)
                {
                    cell.Status = CellStatus.Empty;
                }

                // clears the datagrid of values and colours - colours spelt the correct way!!!!!! :-)
                foreach (DataGridViewRow row in dgridBoard.Rows)
                {
                    foreach (DataGridViewCell cell in row.Cells)
                    {
                        cell.Style.BackColor = Color.White;
                        cell.Value = String.Empty;
                    }
                }

                lblMessages.Text = string.Empty;

                // Don't store the return value from the first call to RandomlyGenerateShip as the method will always return true for the first ship as there are no other ships to clash with
                this.RandomlyGenerateShip(CellStatus.Battleship, 5, random, this.battleship); // Create Battleship
                shipCreated = this.RandomlyGenerateShip(CellStatus.Destroyer, 4, random, this.destroyerOne); //  Create Destroyer 1 / 2

                if (shipCreated)
                {
                    shipCreated = this.RandomlyGenerateShip(CellStatus.Destroyer, 4, random, this.destroyerTwo); //  Create Destroyer 2 / 2
                }

            } while (shipCreated == false); // If shipCreated is false, then there was an overlap in the ship's random positions. Therefore re-do the random positioning.
        }

        /// <summary>
        /// create a ship or destroyer
        /// </summary>
        /// <param name="shipType">tyoe of ship</param>
        /// <param name="shipSize">either 4 cells for a Destroyer or 5 cells for a Destroyer</param>
        /// <param name="random">the random number object passing the same one each time to ensure truely random numbers are generated</param>
        /// <param name="ship">paramter to point at ship's squares/cells</param>
        /// <returns> returns true when a ship has been created, otherwise false as the ship would have overlapped with another</returns>
        private bool RandomlyGenerateShip(CellStatus shipType, int shipSize, Random random, List<Cell> ship)
        {
            // Randomly create a ship
            int axis = random.Next(2); // returns either 0 or 1
            if (axis == 0) // drawing the ship horizontally
            {
                // Randomly select the first cell to place the cell.
                var rowNumber = random.Next(1, 11); // gives a row between 1 and 10 as 11 is considered exclusive. As the ship is being drawn horizontally, it can be on any row.
                var colNumber = random.Next(1, 12 - shipSize); // gives a column between 1 and 6 or 7 depending on the ship size. By only allowing the start colNumber to be 6 or 7 means there is room to place the ship cells without going past the 10th column.

                for (int i = colNumber; i < (colNumber + shipSize); i++)
                {
                    var cell = cells.First(c => c.RowNumber == rowNumber && c.Column == DetermineColumnLetter(i));

                    if (cell.Status != CellStatus.Empty)
                    {
                        return false;  // False means no ship created, this shows that there is already a ship in this location, so they will overlap
                    }

                    cell.Status = shipType;
                    //dgridBoard.Rows[rowNumber - 1].Cells[i - 1].Value = shipType == CellStatus.Destroyer ? "D" : "B";// -1 as it's Index starts at 0, not 1 as my grid is set too ***** JLW DELETE THIS JUST TEST PURPOSES TO SEE WHERE THE SHIPS ARE *****

                    ship.Add(cell); // add the cell object to the ship so it builds a list of cells for the ship
                }

                return true; // ship has been created
            }
            else
            {
                // Randomly select the first cell to place the cell.
                var rowNumber = random.Next(1, 12 - shipSize); // gives a row between 1 and 6 or 7 depending on the ship size. By only allowing the start rowNumber to be 6 or 7 means there is room to place all the ship cells without going past the 10th row.
                var colNumber = random.Next(1, 11); // gives a column between 1 and 10 as 11 is considered exclusive. As the ship is being drawn vertically, it can be on any column.

                for (int i = rowNumber; i < (rowNumber + shipSize); i++)
                {
                    var cell = cells.First(c => c.RowNumber == i && c.Column == DetermineColumnLetter(colNumber));

                    if (cell.Status != CellStatus.Empty)
                    {
                        return false;  // False means no ship created, this shows that there is already a ship in this location, so they will overlap
                    }

                    cell.Status = shipType;
                    //dgridBoard.Rows[i - 1].Cells[colNumber - 1].Value = shipType == CellStatus.Destroyer ? "D" : "B";// -1 as it's Index starts at 0, not 1 as my grid is set too ***** JLW DELETE THIS JUST TEST PURPOSES TO SEE WHERE THE SHIPS ARE *****


                    ship.Add(cell); // add the cell object to the ship so it builds a list of cells for the ship
                }

                return true; // ship has been created
            }
        }

        private void GameBoard_Load(object sender, EventArgs e)
        {
            dgridBoard.Parent = this;
            dgridBoard.RowCount = 10;
            dgridBoard.ColumnCount = 10;
            dgridBoard.Visible = true;
            for (int rowColumnIndex = 0; rowColumnIndex < 10; rowColumnIndex++)
            {
                dgridBoard.Columns[rowColumnIndex].HeaderText = this.DetermineColumnLetter(rowColumnIndex + 1);
                dgridBoard.Columns[rowColumnIndex].Name = this.DetermineColumnLetter(rowColumnIndex + 1);
                dgridBoard.Columns[rowColumnIndex].Width = 40;
                dgridBoard.Rows[rowColumnIndex].HeaderCell.Value = (rowColumnIndex + 1).ToString();
                dgridBoard.RowHeadersWidth = 50;
                dgridBoard.Rows[rowColumnIndex].Height = 40;
                dgridBoard.Enabled = false;
                dgridBoard.ClearSelection();
            }
        }

        private void btnFire_Click(object sender, EventArgs e)
        {
            lblMessages.Text = string.Empty;

            if (lbColumn.SelectedIndex < 0 || lbRow.SelectedIndex < 0)
            {
                lblMessages.Text = "Please Select a Column and a Row to Fire at";
                return;  //breaks out of the method
            }

            string cellCoordinates = lbColumn.Text + lbRow.Text;

            Cell selectedCell = this.cells.First(c => c.Name == cellCoordinates);
            if (selectedCell.Status == CellStatus.Hit || selectedCell.Status == CellStatus.Miss)
            {
                lblMessages.Text = "This square has been the victim of your attacks already, try another";
                return;
            }

            if (selectedCell.Status == CellStatus.Empty)
            {
                selectedCell.Status = CellStatus.Miss;
                dgridBoard.Rows[int.Parse(lbRow.Text) - 1].Cells[lbColumn.Text].Style.BackColor = Color.FromArgb(255, 192, 128);
            }

            if (selectedCell.Status == CellStatus.Destroyer)
            {
                // Determine if Destroyer One or Destroyer Two has been hit
                int destroyerShipNumberHit;
                if (this.destroyerOne.Any(c => c.Name == selectedCell.Name))
                {
                    destroyerShipNumberHit = 1;
                }
                else
                {
                    destroyerShipNumberHit = 2;
                }

                selectedCell.Status = CellStatus.Hit;
                dgridBoard.Rows[int.Parse(lbRow.Text) - 1].Cells[lbColumn.Text].Style.BackColor = Color.FromArgb(128, 255, 128);

                if (this.cells.Any(c => c.Status == CellStatus.Battleship || c.Status == CellStatus.Destroyer) == false)
                {
                    lblMessages.Text = "CONGRATULATIONS: Both Destroyers and the Battleship have been sunk";
                    btnFire.Enabled = false;
                    return;
                }
                else if (this.destroyerOne.Any(c => c.Status == CellStatus.Destroyer) == false && this.destroyerTwo.Any(c => c.Status == CellStatus.Destroyer) == false)
                {
                    lblMessages.Text = "Both Destroyers have been sunk";
                }
                else if (destroyerShipNumberHit == 1 && this.destroyerOne.Any(c => c.Status == CellStatus.Destroyer) == false)
                {
                    lblMessages.Text = "One Destroyer has been sunk";
                }
                else if (destroyerShipNumberHit == 2 && this.destroyerTwo.Any(c => c.Status == CellStatus.Destroyer) == false)
                {
                    lblMessages.Text = "One Destroyer has been sunk";
                }
            }

            if (selectedCell.Status == CellStatus.Battleship)
            {
                selectedCell.Status = CellStatus.Hit;
                dgridBoard.Rows[int.Parse(lbRow.Text) - 1].Cells[lbColumn.Text].Style.BackColor = Color.FromArgb(128, 255, 128);

                if (this.cells.Any(c => c.Status == CellStatus.Battleship || c.Status == CellStatus.Destroyer) == false)
                {
                    lblMessages.Text = "CONGRATULATIONS: Both Destroyers and the Battleship have been sunk";
                    btnFire.Enabled = false;
                    return;
                }
                else if (this.battleship.Any(c => c.Status == CellStatus.Battleship) == false)
                {
                    lblMessages.Text = "The Battleship has been sunk";
                }
             }
        }
    }
}
