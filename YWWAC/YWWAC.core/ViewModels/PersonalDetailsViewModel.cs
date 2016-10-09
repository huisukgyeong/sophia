using MvvmCross.Core.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YWWAC.core.ViewModels
{
    public class PersonalDetailsViewModel : MvxViewModel
    {
        public MvxCommand GoalSetupViewCommand
        {
            get
            {
                return new MvxCommand(() => ShowViewModel<GoalSetupViewModel>());
            }
        }
    }
}
