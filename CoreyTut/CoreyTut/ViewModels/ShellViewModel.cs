using Caliburn.Micro;
using CoreyTut.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace CoreyTut.ViewModels
{
    public class ShellViewModel : Conductor<object>
    {
        private string _firstName = "Your Name";
        private string _lastName = "Your LastName";
        BindableCollection<PersonModel> _people = new BindableCollection<PersonModel>();
        private PersonModel _selectedPerson;

        private Func<int> f = () => { return 42; };

        public ShellViewModel()
        {
            People.Add(new PersonModel { FirstName = "Tim", LastName = "Corey" });
            People.Add(new PersonModel { FirstName = "John", LastName = "Doe" });
            People.Add(new PersonModel { FirstName = "Marylin", LastName = "Manson" });
            People.Add(new PersonModel { FirstName = "Corey", LastName = "Taylor" });
        }

        public string FirstName
        {
            get { return _firstName; }
            set { 
                _firstName = value;
                NotifyOfPropertyChange(() => FirstName);
                NotifyOfPropertyChange(() => FullName);
            }
        }

        public string LastName
        {
            get { return _lastName; }
            set
            {
                _lastName = value;
                NotifyOfPropertyChange(() => LastName);
                NotifyOfPropertyChange(() => FullName);
            }
        }

        public string FullName
        {
            get { return $"{ FirstName } {LastName}"; }
        }

        public BindableCollection<PersonModel> People
        {
            get { return _people; }
            set { _people = value; }
        }

        public PersonModel SelectedPerson
        {
            get { return _selectedPerson; }
            set
            {
                _selectedPerson = value;
                NotifyOfPropertyChange(() => SelectedPerson);
            }
        }

        public bool CanClearText(string firstName, string lastName)
        {
            return !String.IsNullOrWhiteSpace(firstName) || !String.IsNullOrWhiteSpace(lastName);
        }

        public void ClearText(string firstName, string lastName)
        {

            FirstName = "";
            LastName = "";
        }

        public void LoadPageOne()
        {
            ActivateItem(new FirstChildViewModel());
        }

        public void LoadPageTwo()
        {
            ActivateItem(new SecondChildViewModel());
        }
    }
}
