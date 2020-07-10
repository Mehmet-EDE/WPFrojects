using FirstProject.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace FirstProject.View
{
    /// <summary>
    /// UserView.xaml etkileşim mantığı
    /// </summary>
    public partial class UserView : Window,IDisposable
    {
        private UserViewModel userViewModel;
        public UserView()
        {
            this.userViewModel = new UserViewModel();
            InitializeComponent();
            this.DataContext = this.userViewModel;
        }

        public void Dispose()
        {
            GC.SuppressFinalize(this);
            GC.Collect();
        }
    }
}
