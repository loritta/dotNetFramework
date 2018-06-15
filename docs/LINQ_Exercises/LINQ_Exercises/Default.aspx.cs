using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using LINQ_Exercises.Models;

namespace LINQ_Exercises
{
    public partial class Default : System.Web.UI.Page
    {
        //
        List<Student> studentList = new List<Student>
        {
            new Student {First="Bob", Last="Jones", ID=111, Age=15, Scores= new List<int> {69, 92, 81, 60}},
            new Student {First="Claire", Last="Simpson", ID=112, Age=17, Scores= new List<int> {75, 84, 83, 39}},
            new Student {First="John", Last="Feetham", ID=113, Age=21, Scores= new List<int> {65, 94, 65, 91}},
            new Student {First="Jonathan", Last="Potts", ID=114, Age=10, Scores= new List<int> {97, 83, 85, 62}},
            new Student {First="Pepe", Last="Garcia", ID=115, Age=20, Scores= new List<int> {35, 72, 91, 70}},
            new Student {First="Samantha", Last="Fakhouri", ID=116, Age=17, Scores= new List<int> {99, 86, 90, 54}},
            new Student {First="Roger", Last="Song", ID=117, Age=19, Scores= new List<int> {60, 72, 64, 45}},
            new Student {First="Hugo", Last="Garcia", ID=118, Age=15, Scores= new List<int> {92, 90, 83, 78}},
            new Student {First="Richard", Last="Ammerman", ID=119, Age=14, Scores= new List<int> {68, 79, 81, 92}},
            new Student {First="Kevin", Last="Adamson", ID=120, Age=11, Scores= new List<int> {68, 71, 81, 79}},
            new Student {First="Jeet", Last="Singh", ID=121, Age=12, Scores= new List<int> {96, 85, 91, 60}}
        };

        List<Staff> teacherList = new List<Staff>
        {
            new Staff {First="Jeet", Last="Singh", ID=900},
            new Staff {First="Richard", Last="Potter", ID=901},
            new Staff {First="Terry", Last="Woodward", ID=902},
            new Staff {First="Bob", Last="Feetham", ID=903},
            new Staff {First="Jane", Last="Feetham", ID=904},
            new Staff {First="Oliver", Last="Jones", ID=905},
            new Staff {First="Rafael", Last="Sacramento", ID=906},
            new Staff {First="John", Last="Smith", ID=907},
            new Staff {First="Pepe", Last="Garcia", ID=908}
        };

        List<Course> courseList = new List<Course>
        {
            new Course{Code="100AB",Name="Intro To Computers",Semester="Fall",Duration=15},
            new Course{Code="101AB",Name="Programming I",Semester="Winter",Duration=15},
            new Course{Code="102AB",Name="Programming II",Semester="Fall",Duration=15},
            new Course{Code="103AB",Name="Database I",Semester="Summer",Duration=5},
            new Course{Code="104AB",Name="Database II",Semester="Summer",Duration=5},
            new Course{Code="303ER",Name="Applied Mathematics",Semester="Summer",Duration=5},
            new Course{Code="304ER",Name="Pure Mathematics",Semester="Fall",Duration=15},
            new Course{Code="588A",Name="English Language",Semester="Winter",Duration=10},
            new Course{Code="589A",Name="English Literature",Semester="Winter",Duration=10},
            new Course{Code="588B",Name="More English Language",Semester="Fall",Duration=10},
            new Course{Code="589B",Name="More English Literatute",Semester="Fall",Duration=10},
            new Course{Code="123Z",Name="Basic Biology",Semester="Winter",Duration=15},
            new Course{Code="123Y",Name="Basic Chemistry",Semester="Fall",Duration=15},
            new Course{Code="123X",Name="Basic Physics",Semester="Summer",Duration=8}
        };

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void ddlLists_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ddlLists.SelectedIndex == 1)
            {
                gvDisplay.DataSource = studentList;
            }
                
            else if (ddlLists.SelectedIndex == 2)
                gvDisplay.DataSource = teacherList;
            else if (ddlLists.SelectedIndex == 3)
                gvDisplay.DataSource = courseList;

            gvDisplay.DataBind();
            ListBox1.SelectedIndex = 0;
        }



        protected void ListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            result.Text = "";
            switch (ListBox1.SelectedIndex)
            {
                case 1://1: Students who are under 18 years of age (in order of age)
                    var student18 = from s in studentList where s.Age < 18 orderby s.Age select s;
                    //gvDisplay.DataSource = student18;
                    //gvDisplay.DataBind();
                    foreach (var s in student18)
                    {
                        result.Text += string.Format("- {0}, {1}, {2} \n", s.Last,s.First, s.Age);
                    }
                    break;
                case 2:
                    //Students who are teenagers (alphabetical order by last name)
                    var studentTeen = from s in studentList where s.Age > 12 && s.Age < 20 orderby s.Last select s;
                    foreach (var s in studentTeen)
                    {
                        result.Text += string.Format("- {0}, {1}, {2} \n", s.Last, s.First, s.Age);
                    }
                    break;
                case 3:
                    //Students who scored 80 or more in their last test (order by score descending)
                    var studnetPassedLastTest = from s in studentList where s.Scores[3] >= 80 orderby s.Scores[3] descending select s;
                    foreach (var s in studnetPassedLastTest)
                    {
                        result.Text += string.Format("- {0}, {1}, {2} \n", s.Last, s.First, s.Scores[3]);
                    }
                    break;
                case 4:
                    //Students who scored over 320 marks in total (across all their tests)
                    var studentTotalScore = from s in studentList
                                            where (s.Scores.Sum()) >= 320 select s;
                    foreach (var s in studentTotalScore)
                    {
                        result.Text += string.Format("- {0}, {1}, {2} \n", s.Last, s.First, s.Scores.Sum());
                    }
                    break;
                case 5:
                    //Students who scored at least 60 in all of their tests
                    var studentsAllOver60 = from s in studentList
                                            where (s.Scores[0] >= 60 && s.Scores[1] >= 60 && s.Scores[2] >= 60 && s.Scores[3] >= 60)
                                            select s;
                    foreach (var s in studentsAllOver60)
                    {
                        result.Text += string.Format("- {0}, {1}, {2}, {3}, {4}, {5} \n", s.Last, s.First, s.Scores[0], s.Scores[1], s.Scores[2], s.Scores[3]);
                    }
                    break;
                case 6:
                    //Students grouped by first letter of their last name
                    var sBylastName = from s in studentList
                                      group s by s.Last[0] into studentGroup
                                      orderby studentGroup.Key
                                      select studentGroup;
                    foreach (var group in sBylastName)
                    {
                        result.Text += group.Key +"\n";
                        foreach (var s in group)
                        {
                            result.Text += string.Format("- {0}, {1} \n", s.Last, s.First);
                        }
                    }
                    break;
                case 7:
                    //Average score of each test
                    var StudentTest1AVG = from s in studentList select s.Scores[0];
                    double test1Avg = StudentTest1AVG.Average();
                    result.Text += "Avg score for test 1 = " + test1Avg.ToString("0.00");
                    var StudentTest2AVG = from s in studentList select s.Scores[1];
                    double test2Avg = StudentTest2AVG.Average();
                    result.Text += "Avg score for test 2 = " + test2Avg.ToString("0.00");
                    var StudentTest3AVG = from s in studentList select s.Scores[2];
                    double test3Avg = StudentTest3AVG.Average();
                    result.Text += "Avg score for test 3 = " + test3Avg.ToString("0.00");
                    var StudentTest4AVG = from s in studentList select s.Scores[3];
                    double test4Avg = StudentTest4AVG.Average();
                    result.Text += "Avg score for test 4 = " + test4Avg.ToString("0.00");
                    break;
                case 8:
                    //Students who are also teachers

                    break;
                case 9:
                    //Courses of a duration of 15 weeks

                    break;
                case 10:
                    //Courses held in the Winter semester (order by duration)

                    break;
                case 11:
                    //Courses grouped by semester 

                    break;
                default:
                    break;
            }

        }
    }
}