using MvvmCross.Core.ViewModels;
using YWWAC.core.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using YWWAC.core.Interfaces;

namespace YWWAC.core.ViewModels
{
    public class ConsultationViewModel : MvxViewModel
    {
        private ObservableCollection<Consultant> consultants = new ObservableCollection<Consultant>();
        private readonly IConsultantsDatabase consultantsDatabase;
        public ObservableCollection<Consultant> Consultants
        {
            get { return consultants; }
            set { SetProperty(ref consultants, value); }
        }
        public ICommand AddNewConsultantCommand { get; private set; }
        public ICommand SelectConsultantCommand { get; private set; }
        public ConsultationViewModel(IConsultantsDatabase consultantsDatabase)
        {
            this.consultantsDatabase = consultantsDatabase;
            AddNewConsultantCommand = new MvxCommand(() => ShowViewModel<AddConsultantViewModel>());
            SelectConsultantCommand = new MvxCommand<Consultant>(selectedConsultant => ShowViewModel<ConsultantViewModel>(selectedConsultant));
        }
        public void OnResume()
        {
            GetConsultantData();
        }
        public async void GetConsultantData()
        {
            var consultantResults = await consultantsDatabase.GetConsultants();
            Consultants.Clear();
            foreach (var consultant in consultantResults)
            {
                if (consultant != null)
                {
                    Consultants.Add(new Consultant(consultant.Name, consultant.Profession, consultant.Contact, consultant.Institution));
                }
                else
                {
                    consultantsDatabase.DeleteConsultant(consultant.Id);
                }
            }
        }
    }
}
