using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore.ChangeTracking;

public class userAccountModel{

    public int Id { get; set; }

    public String username { get; set; }

    public String name { get; set; }
    public String surname { get; set; }

    protected String email { get; set; }
    private String password { get; set; }

    protected String adress { get; set; }
    
    protected DateTime createdAt{ get; set; }
    protected DateTime updatedAt { get; set; }

}