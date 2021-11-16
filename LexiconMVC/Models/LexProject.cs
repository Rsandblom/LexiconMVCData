using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LexiconMVC.Models
{
    public class LexProject
    {
        public LexProject(string projectName, string projectLink, string projectDescription )
        {
            ProjectName = projectName;
            ProjectLink = projectLink;
            ProjectDescription = projectDescription;
        }

        public string ProjectName { get; set; }
        public string ProjectLink { get; set; }
        public string ProjectDescription { get; set; }

        public static List<LexProject> GetLexProjects()
        {
            List<LexProject> projectList = new List<LexProject>() {
            new LexProject("Lexicon Sokoban", "https://github.com/Rsandblom/LexiconSokoban", "A simple Sokoban game with one level."),
            new LexProject("Lexicon Frontend", "https://github.com/Rsandblom/FrontEndAssignment1and2", "Basic html and css."),
            new LexProject("Lexicon Vending Machine", "https://github.com/Rsandblom/LexiconVendingMachine", "OOP training, including interface and abstract classes."),
            new LexProject("Lexicon TodoIt", "https://github.com/Rsandblom/LexiconTodoIT", "A todo it app library."),
            new LexProject("Lexicon Test Calculator", "https://github.com/Rsandblom/LexiconTestCalculator", "A calculator app with a test project."),
            new LexProject("Lexicon Hangman", "https://github.com/Rsandblom/LexiconHangman", "A text based hangman game."),
            new LexProject("Lexicon Calculator", "https://github.com/Rsandblom/LexiconCalculator", "A calculator app with.")
            };

            return projectList;
        }
    }

    
}
