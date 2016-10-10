using MvvmCross.Core.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using YWWAC.core.Interfaces;
using YWWAC.core.Models;

namespace YWWAC.core.ViewModels
{
    public class AddConsultantViewModel : MvxViewModel
    {
        private readonly IConsultantsDatabase consultantsDatabase;
        private string name;
        public string Name
        {
            get { return name; }
            set
            {
                SetProperty(ref name, value);
            }
        }
        private string contact;
        public string Contact
        {
            get { return contact; }
            set
            {
                SetProperty(ref contact, value);
            }
        }
        private string institution;
        public string Institution
        {
            get { return institution; }
            set
            {
                SetProperty(ref institution, value);
            }
        }
        public ICommand AddConsultantCommand { get; private set; }
        public AddConsultantViewModel(IConsultantsDatabase consultantsDatabase)
        {
            this.consultantsDatabase = consultantsDatabase;
            AddConsultantCommand = new MvxCommand(() =>
            {
                Consultant newConsultant = new Consultant(Name, Contact, Institution);
                AddConsultant(newConsultant);
            });
        }
        public async void AddConsultant(Consultant newConsultant)
        {
            await consultantsDatabase.InsertConsultant(newConsultant);
            Close(this);
        }
    }
}
