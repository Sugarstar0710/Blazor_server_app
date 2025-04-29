namespace blazor_server_app.ViewModels;

class PersonViewModel
{
    public int Id { get; set; } = 1;
    public string Name { get; set; } = "ABC";
    public int Age { get; set; } = 18;
    public string image { get; set; } = "";
    public PersonViewModel()
    {
        image = $"http://i.pravatar.cc?u=1{Id}";
    }
    public PersonViewModel(int newId, string newName, int newAge)
    {
        Id = newId;
        Name = newName;
        Age = newAge;
        image = $"http://i.pravatar.cc?u=1{Id}";
    }
}