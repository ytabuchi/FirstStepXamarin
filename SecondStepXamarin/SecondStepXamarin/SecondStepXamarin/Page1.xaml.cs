using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace SecondStepXamarin
{
    public partial class Page1 : ContentPage
    {
        public Page1()
        {
            InitializeComponent();

            var person = new List<Person>
            {
                new Person("田淵義人","港区","ソフトウェア事業部",41,924,"ytabuchi_201404.jpg"),
                new Person("JohnSilverstain","MELBOURNE","Marketing",29,243,"friend_thumbnail_27.jpg"),
                new Person("PamTailor","SIDNEY","Design",32,24,"friend_thumbnail_75.jpg"),
                new Person("CasyNiman","HOBART","Accounts",58,267,"friend_thumbnail_93.jpg"),
                new Person("GorgeTach","NEWCASTLE","Design",29,127,"friend_thumbnail_55.jpg"),
                new Person("CristinaMaciel","HOBART","MobileDev.",32,80,"friend_thumbnail_31.jpg"),
                new Person("SimonDeuva","MELBOURNE","Media",58,420,"friend_thumbnail_34.jpg")
            };
            this.BindingContext = person;
        }
    }

    public class Person
    {
        public string Name { get; }
        public string City { get; }
        public string Department { get; }
        public int Age { get; }
        public int Followers { get; }
        public ImageSource Photo { get; }

        public Person(string name, string city, string depertment, int age, int followers, ImageSource photo)
        {
            this.Name = name;
            this.City = city;
            this.Department = depertment;
            this.Age = age;
            this.Followers = followers;
            this.Photo = photo;
        }
    }
}
