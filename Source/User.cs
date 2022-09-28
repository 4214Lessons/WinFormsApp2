namespace Source;

class User
{
    public string? UserName { get; set; }
    public string? Password { get; set; }

    public User(string? name, string? password)
    {
        UserName = name;
        Password = password;
    }
}
