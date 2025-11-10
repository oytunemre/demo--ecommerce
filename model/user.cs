using System.ComponentModel.DataAnnotations;

public class user
{
   
public int Id;

public String name;
public String surname;


protected String email;
private String password;

protected String adress;

public int getId()
{
    return Id;

}

public void setId(int id)
{
        id = 0;
        id++;
        this.Id = id;
        
}

public String getName()
{
    return name;
}

public void setName(String name)
{
    this.name = name;
}
public String getSurname()
{
    return surname;
}
public void setSurname(String surname)
{
    this.surname = surname;
}
public String getEmail()

{
    return email;
}
public void setEmail(String email)
{
    this.email = email;
}
public String getPassword()
{
    return password;
}                            
public void setPassword(String password)
{
    this.password = password;
}
public String getAdress()
{
    return adress;
}
public void setAdress(String address)
{
    this.adress = address;
}
}