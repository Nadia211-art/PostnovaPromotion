using PostnovaPromotion.Model;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace PostnovaPromotion
{
    /// <summary>
    /// Логика взаимодействия для App.xaml
    /// </summary>
    public partial class App : Application
    {
        public static PromotionPostnovaEntities context = new PromotionPostnovaEntities();
        public static User currentUser = new User();
    }
}
