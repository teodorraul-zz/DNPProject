using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DNPNew
{
    public partial class main : System.Web.UI.Page
    {
        static int index = 0;
        string trainingType;
        int day;
        int duration = 0;
        int week;

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            trainingType = selectTraining.Value;
            int.TryParse(inputWeek.Value, out week);


            switch (selectDay.Value)
            {
                case "Monday":
                    day = 0;
                    break;
                case "Tuesday":
                    day = 1;
                    break;
                case "Wednesday":
                    day = 2;
                    break;
                case "Thursday":
                    day = 3;
                    break;
                case "Friday":
                    day = 4;
                    break;
                case "Saturday":
                    day = 5;
                    break;
                case "Sunday":
                    day = 6;
                    break;
                default:
                    break;
            }

            int.TryParse(inputDuration.Value, out duration);

            if (duration == 0)
                inputDuration.Value = "Enter valid duration";
            else if (week > 23 || week < 20)
                inputWeek.Value = "Enter valid week (20,21,22,23)";
            else
            {
                addRow(trainingType, day, duration, week);
            }
        }

        public void addRow(string trainingType, int day, int duration, int week)
        {
            int currentDay = day;

            int value = 0;

            switch (trainingType)
            {
                case "Insane training":
                    value = 120;
                    break;
                case "Crossfit":
                    value = 100;
                    break;
                case "Running":
                    value = 80;
                    break;
                case "Weights training":
                    value = 70;
                    break;
                default:
                    break;
            }
                
            int calories = duration * value;

            switch (week)
            {
                case 20:
                    {
                        for (int i = 1; i <= 4; i++)
                        {
                            if (myTable20.Rows[i].Cells[day].Text == "")
                            {
                                myTable20.Rows[i].Cells[day].Text = trainingType + "\n" + duration + "min" + "\n" + calories + "kcal";
                                break;
                            }
                            else if (myTable20.Rows[i].Cells[day].Text == "")
                            {
                                myTable20.Rows[++i].Cells[day].Text = trainingType + "\n" + duration + "min" + "\n" + calories + "kcal";
                                break;
                            }

                        }
                        break;
                    }

                case 21:
                    {
                        for (int i = 1; i <= 4; i++)
                        {
                            if (myTable21.Rows[i].Cells[day].Text == "")
                            {
                                myTable21.Rows[i].Cells[day].Text = trainingType + "\n" + duration + "min" + "\n" + calories + "kcal";
                                break;
                            }
                            else if (myTable21.Rows[i].Cells[day].Text == "")
                            {
                                myTable21.Rows[++i].Cells[day].Text = trainingType + "\n" + duration + "min" + "\n" + calories + "kcal";
                                break;
                            }

                        }
                        break;
                    }

                case 22:
                    {
                        for (int i = 1; i <= 4; i++)
                        {
                            if (myTable22.Rows[i].Cells[day].Text == "")
                            {
                                myTable22.Rows[i].Cells[day].Text = trainingType + "\n" + duration + "min" + "\n" + calories + "kcal";
                                break;
                            }
                            else if (myTable22.Rows[i].Cells[day].Text == "")
                            {
                                myTable22.Rows[++i].Cells[day].Text = trainingType + "\n" + duration + "min" + "\n" + calories + "kcal";
                                break;
                            }

                        }
                        break;
                    }

                case 23:
                    {
                        for (int i = 1; i <= 4; i++)
                        {
                            if (myTable23.Rows[i].Cells[day].Text == "")
                            {
                                myTable23.Rows[i].Cells[day].Text = trainingType + "\n" + duration + "min" + "\n" + calories + "kcal";
                                break;
                            }
                            else if (myTable23.Rows[i].Cells[day].Text == "")
                            {
                                myTable23.Rows[++i].Cells[day].Text = trainingType + "\n" + duration + "min" + "\n" + calories + "kcal";
                                break;
                            }

                        }
                        break;
                    }

                default:
                    break;
            }
     
        }

    }
}