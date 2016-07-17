using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.DoFactory.GangOfFour.CreationalPatterns.Factory.RealWorld
{
    public abstract class Page { }
    public class SkillsPage : Page { }
    public class EducationPage : Page { }
    public class ResultsPage : Page { }
    public class ConclusionPage : Page { }
    public class SummaryPage : Page { }
    public class BibliographyPage : Page { }
    public class ExperiencePage : Page { }
    public class IntroductionPage : Page { }

    public abstract class Document
    {
        private List<Page> _pages = new List<Page>();

        public Document()
        {
            this.CreatePages();
        }

        public List<Page> Pages
        {
            get
            {
                return _pages;
            }

        }

        public abstract void CreatePages();
    }

    public class Resume : Document
    {
        public override void CreatePages()
        {
            Pages.Add(new SkillsPage());
            Pages.Add(new EducationPage());
            Pages.Add(new ExperiencePage());
        }
    }

    public class Report : Document
    {
        public override void CreatePages()
        {
            Pages.Add(new IntroductionPage());
            Pages.Add(new ResultsPage());
            Pages.Add(new ConclusionPage());
            Pages.Add(new SummaryPage());
            Pages.Add(new BibliographyPage());
        }
    }


}
