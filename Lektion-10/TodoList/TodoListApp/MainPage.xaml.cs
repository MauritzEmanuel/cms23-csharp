using System.Collections.ObjectModel;
using TodoListApp.Models;

namespace TodoListApp
{
    public partial class MainPage : ContentPage
    {
        ObservableCollection<Todo> Todos = new ObservableCollection<Todo>()
        {
            new Todo {Activity = "Tvätta bilen"},
            new Todo {Activity = "Hoppa hopprep"}
        };


        public MainPage()
        {
            InitializeComponent();
            TodoList.ItemsSource = Todos;
        }

    }
}