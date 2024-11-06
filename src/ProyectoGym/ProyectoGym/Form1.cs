using Controller;

namespace ProyectoGym
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            var people = PersonController.GetPeople();

            NameText.Text = people[0].Name;
            BirthText.Text = people[0].Birthday.ToString();
        }
    }
}
