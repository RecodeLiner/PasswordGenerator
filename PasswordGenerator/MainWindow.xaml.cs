using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using System;
using System.Linq;
using Windows.ApplicationModel.DataTransfer;

namespace PasswordGenerator
{
    public sealed partial class MainWindow
    {
        // Объявление двух field - пароль и длина пароля и одной переменной - максимальной длины.
        private string _password;
        private int _length;
        private const int MaxLength = 100;
        
        //Инициализация главного окна.
        public MainWindow()
        {
            InitializeComponent();
        }
        
        //Метод на проверку текста в TextBox длины пароля, 
        private void Length_OnBeforeTextChanging(TextBox sender, TextBoxBeforeTextChangingEventArgs args)
        {
            args.Cancel = args.NewText.Any(c => !char.IsDigit(c));
        }        

        //Метод, который будет срабатывать при нажаии на кнопку "Сгенерировать пароль".
        private void Generate_click(object sender, RoutedEventArgs e)
        {
            //Проверка на пустоту поля длины пароля.
            if (String.IsNullOrEmpty(length.Text) != true)
            {
                //Присвоение field длины пароля значения из TextBox путём конвертации String в Int32.
                _length = Convert.ToInt32(length.Text);
            }
            else if (String.IsNullOrEmpty(length.Text) == true)
            {
                //Присвоение field длины пароля значения по умолчанию.
                _length = 12;
            }

            //Проверка на то, что длина пароля не превышает максимальной длины и не меньше нуля.
            if (_length is <= MaxLength and > 0)
            {
                //Присвоению field пароля значение метода GeneratePassword.
                _password = GeneratePasswordClass.GeneratePassword(_length);
                //Вывод сгенерированного пароля в TextBlock.
                pass.Text = _password;
            }
        }

        //Метод, который будет срабатывать при нажаии на кнопку "Копировать пароль".
        private void ClipSet_click(object sender, RoutedEventArgs e)
        {
            //Объявление DataPackage, пакета данных.
            var dataPackage = new DataPackage();
            //Добавление в Datapackage сгенерированного пароля.
            dataPackage.SetText(_password);
            //Установка пакета данных в буфер обмена.
            Clipboard.SetContent(dataPackage);
        }
    }
}