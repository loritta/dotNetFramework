using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using LINQPractice.Models;

namespace LINQPractice
{
    public partial class _default : System.Web.UI.Page
    {
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

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ddlOption.SelectedIndex == 1) { 
                gvDisplay.DataSource = studentList;
                
            }
            else if (ddlOption.SelectedIndex == 2) { 
                gvDisplay.DataSource = teacherList;
                
            }
            else if (ddlOption.SelectedIndex == 3)
            {
                gvDisplay.DataSource = courseList;
                
            }
            gvDisplay.DataBind();

        }

        protected void ListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Students who are under 18 years of age(in order of age) 
            //Students who are teenagers(alphabetical order by last name) 
            //Students who scored 80 or more in their last test(order by score descending)
            //Students who scored over 320 marks in total(across all their tests) 
            //Students who scored at least 60 in all of their tests 
            //Students grouped by first letter of their last name


            switch (ListBox1.SelectedIndex)
            {
                case 1:
                    var result1 = from s in studentList where s.Age < 18 orderby s.Age select s;
                    lbResult.DataSource = result1;
                    lbResult.DataBind();
                    break;
                case 2:
                    var result2 = from s in studentList where s.Age < 19 && s.Age > 12 orderby s.Last
                                  select s;
                    lbResult.DataSource = result2;
                    lbResult.DataBind();
                    break;
                case 3:
                    var result3 = from s in studentList where s.Scores[3] >= 80 orderby s.Scores descending select s ;
                    lbResult.DataSource = result3;
                    lbResult.DataBind();
                    break;
                case 4:
                    var result4 = from s in studentList where s.Scores[0]+ s.Scores[1]+ s.Scores[2]+s.Scores[3] > 320 select s;
                    lbResult.DataSource = result4;
                    lbResult.DataBind();
                    break;
                case 5:
                    var result5 = from s in studentList where s.Scores[0]>60 && s.Scores[1] > 60 && s.Scores[2] > 60 && s.Scores[3] >= 60 select s;
                    lbResult.DataSource = result5;
                    lbResult.DataBind();
                    break;
                case 6:
                    var result6 = from s in studentList let first = s.Last.Substring(0, 1) orderby first select s;
                    lbResult.DataSource = result6;
                    lbResult.DataBind();
                    break;
                    //Average score of each test 
                    //Students who are also teachers 
                    //Courses of a duration of 15 weeks 
                    //Courses held in the Winter semester(order by duration) 
                    //Courses grouped by semester
                case 7:
                    var score1 = from s in studentList select s.Scores[0];
                    var score2 = from s in studentList select s.Scores[1];
                    var score3 = from s in studentList select s.Scores[2];
                    var score4 = from s in studentList select s.Scores[3];
                    double[] scoreAvg = {score1.Average(),score2.Average(),
                     score3.Average(), score4.Average()};
                    var result7 = scoreAvg;
                    lbResult.DataSource = result7;
                    lbResult.DataBind();
                    break;
                case 8:
                    var result8 = from s in studentList
                                  join t in teacherList on new { s.Last, s.First }
                                   equals new { t.Last, t.First }
                                  select s.Last + " " + s.First;
                                  ;
                    lbResult.DataSource = result8;
                    lbResult.DataBind();
                    break;
                case 9:
                    var result9 = from s in studentList let first = s.Last.Substring(0, 1) orderby first select s;
                    lbResult.DataSource = result9;
                    lbResult.DataBind();
                    break;
                case 10:
                    var result10 = from s in studentList let first = s.Last.Substring(0, 1) orderby first select s;
                    lbResult.DataSource = result10;
                    lbResult.DataBind();
                    break;
                case 11:
                    var result11 = from s in studentList let first = s.Last.Substring(0, 1) orderby first select s;
                    lbResult.DataSource = result11;
                    lbResult.DataBind();
                    break;
                default:
                    break;
            }
           
        }
    }
}