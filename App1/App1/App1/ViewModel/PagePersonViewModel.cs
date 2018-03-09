using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace App1.ViewModel
{
    class PagePersonViewModel
    {
        public PagePersonViewModel()
        {
            for (int i = 0; i < 5; i++)
            {
                Person person = new Person();
               
                person.FirstName = "Renier";
                person.LastName = "Valdes" + i.ToString();
                person.Name = person.FirstName + person.LastName;
                person.Address = i.ToString() + " Main Street";
                person.ImageSource = "icon.jpg";
                People.Add(person);
            }
        }

        public ObservableCollection<Person> People { get; set; } = new ObservableCollection<Person>();

    }
}
