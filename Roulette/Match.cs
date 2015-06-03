using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Roulette
{
    public static class Match
    {
        //http//stackoverflow.com/questions/1293058/round-robin-tournament-algorithm-in-c-sharp

        public static void PlayRound(RichTextBox output, List<Seed> row1, List<Seed> row2)
        {
            for (int i = 0; i < row1.Count; i++)
            {
                row1[i].Played.Add(row2[i]);

    
                if (row1[i].Name != string.Empty && row2[i].Name != string.Empty)
                {
                    output.AppendText(row1[i].Name + " vs " + row2[i].Name + "\n");
                }
                else
                {
                    output.AppendText("Seed " + row1[i].ID + " vs Seed " + row2[i].ID + "\n");
                }
            }

            RotateSeeds(row1, row2);
        }

        public static void PlayRoundWithBye(RichTextBox output, List<Seed> row1, List<Seed> row2)
        {
            for (int i = 0; i < row1.Count; i++)
            {
                row1[i].Played.Add(row2[i]);

                if(row1[i].Name.Equals("bye"))
                {
                    if (row2[i].Name != string.Empty)
                    {
                        output.AppendText(row2[i].Name + " has a bye for this round\n");
                    }
                    else
                    {
                        output.AppendText("Seed " + row2[i].ID + " has a bye for this round\n");
                    }
                }
                else if (row2[i].Name.Equals("bye"))
                {
                    if (row1[i].Name != string.Empty)
                    {
                        output.AppendText(row1[i].Name + " has a bye for this round\n");
                    }
                    else
                    {
                        output.AppendText("Seed " + row1[i].ID + " has a bye for this round\n");
                    }
                }
                else if (row1[i].Name != string.Empty && row2[i].Name != string.Empty)
                {
                    output.AppendText(row1[i].Name + " vs " + row2[i].Name + "\n");
                }
                else
                {
                    output.AppendText("Seed " + row1[i].ID + " vs Seed " + row2[i].ID + "\n");
                }
                
            }

            RotateSeeds(row1, row2);
        }


        public static void RotateSeeds(List<Seed> row1, List<Seed> row2)
        {
            Seed shiftIn = null;
            Seed shiftOut = null;
            Seed rowOneCarry = null;
            Seed rowTwoCarry = null;

            //handle row 1
            for (int i = 1; i < row1.Count; i++) //skip i=0 because that value is the anchor and will never shift
            {
                if (i == row1.Count - 1) //last position in row (can trigger first if size of row == 2)
                {
                    rowOneCarry = row1[i];
                    row1[i] = shiftIn;
                }
                else if (i == 1) //first position in row (will only trigger if size of row > 2)
                {
                    shiftIn = row1[i]; //a seed will be shifted in from the second row, we handle that scenario later
                }
                else //mid position(s) in row
                {
                    shiftOut = row1[i];
                    row1[i] = shiftIn;
                    shiftIn = shiftOut;
                }
            }

            //handle row 2
            for (int i = row2.Count - 1; i >= 0; i--) //shift right to left
            {
                if (i == row2.Count - 1) // first position, needs to shift in pushed out value from top row.
                {
                    shiftIn = row2[i];
                    row2[i] = rowOneCarry;

                    if (i == 0) //edge case where row size == 1
                    {
                        rowTwoCarry = shiftIn;
                    }
                }
                else if (i == 0) // end position
                {
                    rowTwoCarry = row2[i];
                    row2[i] = shiftIn;
                }
                else //mid position(s) in row
                {
                    shiftOut = row2[i];
                    row2[i] = shiftIn;
                    shiftIn = shiftOut;
                }
            }

            //shift last value to index 1 of row 1.
            row1[1] = rowTwoCarry;
        }
    }
}
