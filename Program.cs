using System;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Text.RegularExpressions;
public class CharacterInfo
{
    private string name;
    private string sex;
    private string Class;
    private string body;
    private string species;
    private string gender;
    public string getName
    {
        get { return name; }
        set { this.name = value; }
    }
    public string getSex
    {
        get { return sex; }
        set { this.sex = value; }
    }
    public string getCharClass
    {
        get { return Class; }
        set { this.Class = value; }
    }
    public string getBody
    {
        get { return body; }
        set { this.body = value; }
    }
    public string getSpecies
    {
        get { return species; }
        set { this.species = value; }
    }
    public string getGender
    {
        get { return gender; }
        set { this.gender = value; }
    }
}
public abstract class perks
{
    public abstract void PerkMessage();
}
public class damage : perks
{
    public override void PerkMessage()
    {
        Console.WriteLine("\t\t\t\t    Your character now deals +5% more damage!");
    }
}
public class kuripot : perks
{
    public override void PerkMessage()
    {
        Console.WriteLine("\t\t\tNPC's now sell their equipments for -5% less in the original price!");
    }
}
public class matigas : perks
{
    public override void PerkMessage()
    {
        Console.WriteLine("\t\t\t   Your character now gains +5% Damage Reduction!");
    }
}
public class buhok
{
    public void hair()
    {
        Console.Write("\t\t\t    What is your hair type?(1.Curly, 2.Straight, 3.Bald): ");
    }
    public void hair(string color)
    {
        Console.Write(color);
    }
}
public interface colors
{
    void whatColor();
}
public class coloreye : colors
{
    public void whatColor()
    {
        Console.Write("\t\t  What eye color do you want?(1.Brown, 2.Blue, 2.Black, 3.Red, 4.Grey, 5.Green): ");
    }
}
public class colorskin : colors
{
    public void whatColor()
    {
        Console.Write("\t\t\tWhat Skin Color do you want?(1.Dark, 2.Pale, 3.Tan, 4.Fair Skin): ");
    }
}
public class helmetcolor : colors
{
    public void whatColor()
    {
        Console.Write("\t\t\t\tHelmet Color do you want?(1.Silver, 2.Gold, 3.Brown): ");
    }
}
public class armorcolor : colors
{
    public void whatColor()
    {
        Console.Write("\t\t\t      What Armor Color do you want?(1.Silver, 2.Gold, 3.Brown): ");
    }
}
struct looks
{
    public string helmet;
    public string armor;
    public string helmetcolor;
    public string armorcolor;
    public string accessories;
    public string pet;
    public string eyecolors;
    public string skincolors;
    public string mouth;
}
//main method
public class MainClass
{
    static bool IsNameExists(string name)
    {
        string connectionString = @"Data Source = (localdb)\MSSQLLocalDB; Initial Catalog = C:\USERS\USER\SOURCE\REPOS\LAST NA TAGALA TO\LAST NA TAGALA TO\DATABASENAMIN.MDF; Integrated Security = True";
        using (SqlConnection connection = new SqlConnection(connectionString))
        {
            connection.Open();
            string query = "SELECT COUNT(*) FROM Character_Information WHERE name = @Name";
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@Name", name);
                int count = (int)command.ExecuteScalar();
                return count > 0;
            }
        }
    }
    static void Main()
    {
        SqlConnection sqlConnectMoKoMamSir;
        string databaseMoConnectionString = @"Data Source = (localdb)\MSSQLLocalDB; Initial Catalog = C:\USERS\USER\SOURCE\REPOS\LAST NA TAGALA TO\LAST NA TAGALA TO\DATABASENAMIN.MDF; Integrated Security = True";
        sqlConnectMoKoMamSir = new SqlConnection(databaseMoConnectionString);
        sqlConnectMoKoMamSir.Open();
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine("\t\t\t\t=============================================");
        Console.WriteLine("     \t\t\t\t       WELCOME TO OUR CONSOLE APPLICATION!");
        Console.WriteLine("\t\t\t\t=============================================");
        Console.WriteLine("\t\t\t\t            Press Enter to Continue.");
        string asd = Console.ReadLine();
        Console.Clear();
        int c1 = 1;
        while (true)
        {
            try
            {
                Console.WriteLine("\t\t\t\t=============================================");
                Console.WriteLine("     \t\t\t\t             WELCOME TO MAIN MENU!");
                Console.WriteLine("\t\t\t\t=============================================");
                Console.WriteLine("\t\t\t\t\t  Choose an action!");
                Console.WriteLine("\t\t\t\t\t  1.Start new game \n\t\t\t\t\t  2.Load Game \n\t\t\t\t\t  3.Exit Program");
                Console.Write("\t\t\t\t\t  Choice: ");
                Console.ForegroundColor = ConsoleColor.DarkRed;
                int nick = Convert.ToInt32(Console.ReadLine());
                Console.ResetColor();
                if (nick == 1)
                {
                    Console.WriteLine("\t\t\t\t---------------------------------------------");
                    Console.WriteLine("         \t\t\t\tWelcome to Character Creation!");
                    Console.WriteLine("\t\t\t\t---------------------------------------------");
                    CharacterInfo info = new CharacterInfo();
                    while (true)
                    {
                        Console.Write("\t\t\t\t           What is your name?: ");
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        string nameinput = Console.ReadLine();
                        Console.ResetColor();
                        Console.WriteLine();
                        info.getName = nameinput;
                        if (nameinput == "")
                        {
                            Console.ForegroundColor = ConsoleColor.DarkRed;
                            Console.WriteLine("\t\t\t\t\t Invalid Input, Try Again!");
                            Console.ResetColor();
                        }
                        else if (IsNameExists(info.getName))
                        {
                            Console.ForegroundColor = ConsoleColor.DarkRed;
                            Console.WriteLine("\t\t\t\t\t Username already taken!");
                            Console.ResetColor();
                        }
                        else if (Regex.IsMatch(nameinput, @"[^a-zA-Z0-9/<>*/+-_()&^%$#@!~,.\|=:;?]"))
                        {
                            Console.ForegroundColor = ConsoleColor.DarkRed;
                            Console.WriteLine("\t\t\t\t\t Invalid Input, Try Again!");
                            Console.ResetColor();
                        }
                        else
                        {
                            break;
                        }
                    }
                    while (true)
                    {
                        try
                        {
                            Console.Write("\t\t\t\t     What is your sex?(1.Male, 2.Female): ");
                            Console.ForegroundColor = ConsoleColor.DarkRed;
                            int sexinput = Convert.ToInt32(Console.ReadLine());
                            Console.ResetColor();
                            Console.WriteLine();
                            if (sexinput == 1)
                            {
                                info.getSex = "Male";
                                info.getGender = "his";
                                break;
                            }
                            else if (sexinput == 2)
                            {
                                info.getSex = "Female";
                                info.getGender = "her";
                                break;
                            }
                            else
                            {
                                Console.ForegroundColor = ConsoleColor.DarkRed;
                                Console.WriteLine("\t\t\t\t\t Invalid Input, Try again");
                                Console.ResetColor();
                            }
                        }
                        catch (Exception e)
                        {
                            Console.ForegroundColor = ConsoleColor.DarkRed;
                            Console.WriteLine("\t\t\t\t\tInvalid String Input, Try Again!");
                            Console.ResetColor();
                        }
                    }
                    while (true)
                    {
                        try
                        {
                            Console.Write("\t\t\tWhat is your Character's Class?(1.Warrior, 2.Mage, 3.Lancer, 4.Archer): ");
                            Console.ForegroundColor = ConsoleColor.DarkRed;
                            int classinput = Convert.ToInt32(Console.ReadLine());
                            Console.ResetColor();
                            Console.WriteLine();
                            if (classinput == 1)
                            {
                                info.getCharClass = "Warrior";
                                break;
                            }
                            else if (classinput == 2)
                            {
                                info.getCharClass = "Mage";
                                break;
                            }
                            else if (classinput == 3)
                            {
                                info.getCharClass = "Lancer";
                                break;
                            }
                            else if (classinput == 4)
                            {
                                info.getCharClass = "Archer";
                                break;
                            }
                            else
                            {
                                Console.ForegroundColor = ConsoleColor.DarkRed;
                                Console.WriteLine("\t\t\t\t\t Invalid Input, Try Again");
                                Console.ResetColor();
                            }
                        }
                        catch (FormatException e)
                        {
                            Console.ForegroundColor = ConsoleColor.DarkRed;
                            Console.WriteLine("\t\t\t\t\tInvalid String Input, Try Again!");
                            Console.ResetColor();
                        }
                    }

                    while (true)
                    {
                        try
                        {
                            Console.Write("\t\t\t\tEnter your Body Type(1.Buffed, 2.Slim, 3.Skinny): ");
                            Console.ForegroundColor = ConsoleColor.DarkRed;
                            int bodyinput = Convert.ToInt32(Console.ReadLine());
                            Console.ResetColor();
                            Console.WriteLine();
                            if (bodyinput == 1)
                            {
                                info.getBody = "Buffed";
                                break;
                            }
                            else if (bodyinput == 2)
                            {
                                info.getBody = "Slim";
                                break;
                            }
                            else if (bodyinput == 3)
                            {
                                info.getBody = "Skinny";
                                break;
                            }
                            else
                            {
                                Console.ForegroundColor = ConsoleColor.DarkRed;
                                Console.WriteLine("\t\t\t\t\t Invalid Input, Try Again");
                                Console.ResetColor();
                            }
                        }
                        catch (FormatException e)
                        {
                            Console.ForegroundColor = ConsoleColor.DarkRed;
                            Console.WriteLine("\t\t\t\tInvalid String Input, Try Again!");
                            Console.ResetColor();
                        }
                    }
                    while (true)
                    {
                        try
                        {
                            Console.Write("\t\t     Enter your desired species(1.Angel, 2.Demon, 3.Fairy, 4.Elf, 5.Orc, 6.Human): ");
                            Console.ForegroundColor = ConsoleColor.DarkRed;
                            int speciesinput = Convert.ToInt32(Console.ReadLine());
                            Console.ResetColor();
                            Console.WriteLine();
                            if (speciesinput == 1)
                            {
                                info.getSpecies = "Angel";
                                break;
                            }
                            else if (speciesinput == 2)
                            {
                                info.getSpecies = "Demon";
                                break;
                            }
                            else if (speciesinput == 3)
                            {
                                info.getSpecies = "Fairy";
                                break;
                            }
                            else if (speciesinput == 4)
                            {
                                info.getSpecies = "Elf";
                                break;
                            }
                            else if (speciesinput == 5)
                            {
                                info.getSpecies = "Orc";
                                break;
                            }
                            else if (speciesinput == 6)
                            {
                                info.getSpecies = "Human";
                                break;
                            }
                            else
                            {
                                Console.ForegroundColor = ConsoleColor.DarkRed;
                                Console.WriteLine("\t\t\t\t\t Invalid Input, Try Again!");
                                Console.ResetColor();
                            }
                        }
                        catch (FormatException e)
                        {
                            Console.ForegroundColor = ConsoleColor.DarkRed;
                            Console.WriteLine("\t\t\t\t\tInvalid String Input, Try Again!");
                            Console.ResetColor();
                        }
                    }
                    Console.Clear();
                    Console.WriteLine("\t\t\t\t---------------------------------------------");
                    Console.WriteLine("          \t\t\t\tWelcome to Character Design!");
                    Console.WriteLine("\t\t\t\t---------------------------------------------");
                    buhok question = new buhok();
                    string hairtype = "";
                    while (true)
                    {
                        try
                        {
                            question.hair();
                            Console.ForegroundColor = ConsoleColor.DarkRed;
                            int hairtypeinput = Convert.ToInt32(Console.ReadLine());
                            Console.ResetColor();
                            Console.WriteLine();
                            if (hairtypeinput == 1)
                            {
                                hairtype = "Curly";
                                break;
                            }
                            else if (hairtypeinput == 2)
                            {
                                hairtype = "Straight";
                                break;
                            }
                            else if (hairtypeinput == 3)
                            {
                                hairtype = "Bald";
                                break;
                            }
                            else
                            {
                                Console.ForegroundColor = ConsoleColor.DarkRed;
                                Console.WriteLine("\t\t\t\t\t Invalid Input, Please Try Again!");
                                Console.ResetColor();
                            }
                        }
                        catch (FormatException e)
                        {
                            Console.ForegroundColor = ConsoleColor.DarkRed;
                            Console.WriteLine("\t\t\t\t\tInvalid String Input, Try Again!");
                            Console.ResetColor();
                        }
                    }
                    string haircolor = "";
                    while (true)
                    {
                        try
                        {
                            question.hair("\t What is your Hair Color?(1.Black, 2.White, 3.Red, 4.Blue, 5.Yellow, 6.Green, 7.Grey, 8.Violet, 9.Pink): ");
                            Console.ForegroundColor = ConsoleColor.DarkRed;
                            int haircolorinput = Convert.ToInt32(Console.ReadLine());
                            Console.ResetColor();
                            Console.WriteLine();
                            if (haircolorinput == 1)
                            {
                                haircolor = "Black";
                                break;
                            }
                            else if (haircolorinput == 2)
                            {
                                haircolor = "White";
                                break;
                            }
                            else if (haircolorinput == 3)
                            {
                                haircolor = "Red";
                                break;
                            }
                            else if (haircolorinput == 4)
                            {
                                haircolor = "Blue";
                                break;
                            }
                            else if (haircolorinput == 5)
                            {
                                haircolor = "Yellow";
                                break;
                            }
                            else if (haircolorinput == 6)
                            {
                                haircolor = "Green";
                                break;
                            }
                            else if (haircolorinput == 7)
                            {
                                haircolor = "Grey";
                                break;
                            }
                            else if (haircolorinput == 8)
                            {
                                haircolor = "Violet";
                                break;
                            }
                            else if (haircolorinput == 9)
                            {
                                haircolor = "Pink";
                                break;
                            }
                            else
                            {
                                Console.ForegroundColor = ConsoleColor.DarkRed;
                                Console.WriteLine("\t\t\t\t\t Invalid Input, Please Try Again!");
                                Console.ResetColor();
                            }
                        }
                        catch (FormatException e)
                        {
                            Console.ForegroundColor = ConsoleColor.DarkRed;
                            Console.WriteLine("\t\t\t\t\tInvalid String Input, Try Again!");
                            Console.ResetColor();
                        }
                    }
                    coloreye eyecolor = new coloreye();
                    colorskin skincolor = new colorskin();
                    helmetcolor colorhelmet = new helmetcolor();
                    armorcolor colorarmor = new armorcolor();
                    looks looks1;
                    looks1.eyecolors = "";
                    while (true)
                    {
                        try
                        {
                            eyecolor.whatColor();
                            Console.ForegroundColor = ConsoleColor.DarkRed;
                            int eyecolorinput = Convert.ToInt32(Console.ReadLine());
                            Console.ResetColor();
                            Console.WriteLine();
                            if (eyecolorinput == 1)
                            {
                                looks1.eyecolors = "Brown";
                                break;
                            }
                            else if (eyecolorinput == 2)
                            {
                                looks1.eyecolors = "Blue";
                                break;
                            }
                            else if (eyecolorinput == 3)
                            {
                                looks1.eyecolors = "Black";
                                break;
                            }
                            else if (eyecolorinput == 4)
                            {
                                looks1.eyecolors = "Red";
                                break;
                            }
                            else if (eyecolorinput == 5)
                            {
                                looks1.eyecolors = "Grey";
                                break;
                            }
                            else if (eyecolorinput == 6)
                            {
                                looks1.eyecolors = "Green";
                            }
                            else
                            {
                                Console.ForegroundColor = ConsoleColor.DarkRed;
                                Console.WriteLine("\t\t\t\t\t Invalid Input, Try Again!");
                                Console.ResetColor();
                            }
                        }
                        catch (FormatException e)
                        {
                            Console.ForegroundColor = ConsoleColor.DarkRed;
                            Console.WriteLine("\t\t\t\t\tInvalid String Input, Try Again!");
                            Console.ResetColor();
                        }
                    }
                    looks1.skincolors = "";
                    while (true)
                    {
                        try
                        {
                            skincolor.whatColor();
                            Console.ForegroundColor = ConsoleColor.DarkRed;
                            int skincolorinput = Convert.ToInt32(Console.ReadLine());
                            Console.ResetColor();
                            Console.WriteLine();
                            if (skincolorinput == 1)
                            {
                                looks1.skincolors = "Dark";
                                break;
                            }
                            else if (skincolorinput == 2)
                            {
                                looks1.skincolors = "Pale";
                                break;
                            }
                            else if (skincolorinput == 3)
                            {
                                looks1.skincolors = "Tan";
                                break;
                            }
                            else if (skincolorinput == 4)
                            {
                                looks1.skincolors = "Fair Skin";
                                break;
                            }
                            else
                            {
                                Console.ForegroundColor = ConsoleColor.DarkRed;
                                Console.WriteLine("\t\t\t\t\t Invalid Input, Try Again!");
                                Console.ResetColor();
                            }
                        }
                        catch (FormatException e)
                        {
                            Console.ForegroundColor = ConsoleColor.DarkRed;
                            Console.WriteLine("\t\t\t\t\tInvalid String Input, Try Again!");
                            Console.ResetColor();
                        }
                    }
                    looks1.mouth = "";
                    while (true)
                    {
                        try
                        {
                            Console.Write("\t\tWhat type of mouth do you want?(1.Open Mouth, 2.Straight Face, 3.Grinding Teeth): ");
                            Console.ForegroundColor = ConsoleColor.DarkRed;
                            int mouthinput = Convert.ToInt32(Console.ReadLine());
                            Console.ResetColor();
                            Console.WriteLine();
                            if (mouthinput == 1)
                            {
                                looks1.mouth = "Open Mouth";
                                break;
                            }
                            else if (mouthinput == 2)
                            {
                                looks1.mouth = "Straight Face";
                                break;
                            }
                            else if (mouthinput == 3)
                            {
                                looks1.mouth = "Grinding Teeth";
                                break;
                            }
                            else
                            {
                                Console.ForegroundColor = ConsoleColor.DarkRed;
                                Console.WriteLine("\t\t\t\t\t Invalid Input, Try Again!");
                                Console.ResetColor();
                            }
                        }
                        catch (FormatException e)
                        {
                            Console.ForegroundColor = ConsoleColor.DarkRed;
                            Console.WriteLine("\t\t\t\t\tInvalid String Input, Try Again!");
                            Console.ResetColor();
                        }
                    }
                    looks1.helmet = "";
                    while (true)
                    {
                        try
                        {
                            Console.Write("\t\t  What Helmet do you want?(1.Cervelliere, 2.Spangenhelm, 3.Coppergate Helmet): ");
                            Console.ForegroundColor = ConsoleColor.DarkRed;
                            int helminput = Convert.ToInt32(Console.ReadLine());
                            Console.ResetColor();
                            Console.WriteLine();
                            if (helminput == 1)
                            {
                                looks1.helmet = "Cervelliere";
                                break;
                            }
                            else if (helminput == 2)
                            {
                                looks1.helmet = "Spangenhelm";
                                break;
                            }
                            else if (helminput == 3)
                            {
                                looks1.helmet = "Coppergate Helmet";
                                break;
                            }
                            else
                            {
                                Console.ForegroundColor = ConsoleColor.DarkRed;
                                Console.WriteLine("\t\t\t\t\t Invalid Input, Try Again!");
                                Console.ResetColor();
                            }
                        }
                        catch (FormatException e)
                        {
                            Console.ForegroundColor = ConsoleColor.DarkRed;
                            Console.WriteLine("\t\t\t\t\tInvalid String Input, Try Again!");
                            Console.ResetColor();
                        }
                    }
                    looks1.armor = "";
                    while (true)
                    {
                        try
                        {
                            Console.Write("\t\t     What Armor do you want?(1.Leather, 2.Fabric, 3.Steel, 4.Iron, 5.Copper): ");
                            Console.ForegroundColor = ConsoleColor.DarkRed;
                            int arminput = Convert.ToInt32(Console.ReadLine());
                            Console.ResetColor();
                            Console.WriteLine();
                            if (arminput == 1)
                            {
                                looks1.armor = "Leather";
                                break;
                            }
                            else if (arminput == 2)
                            {
                                looks1.armor = "Fabric";
                                break;
                            }
                            else if (arminput == 3)
                            {
                                looks1.armor = "Steel";
                                break;
                            }
                            else if (arminput == 4)
                            {
                                looks1.armor = "Iron";
                                break;
                            }
                            else if (arminput == 5)
                            {
                                looks1.armor = "Copper";
                                break;
                            }
                            else
                            {
                                Console.ForegroundColor = ConsoleColor.DarkRed;
                                Console.WriteLine("\t\t\t\t\t Invalid Input, Try Again!");
                                Console.ResetColor();
                            }
                        }
                        catch (FormatException e)
                        {
                            Console.ForegroundColor = ConsoleColor.DarkRed;
                            Console.WriteLine("\t\t\t\t\tInvalid String Input, Try Again!");
                            Console.ResetColor();
                        }
                    }
                    looks1.helmetcolor = "";
                    while (true)
                    {
                        try
                        {
                            colorhelmet.whatColor();
                            Console.ForegroundColor = ConsoleColor.DarkRed;
                            int helmcolorinput = Convert.ToInt32(Console.ReadLine());
                            Console.ResetColor();
                            Console.WriteLine();
                            if (helmcolorinput == 1)
                            {
                                looks1.helmetcolor = "Silver";
                                break;
                            }
                            else if (helmcolorinput == 2)
                            {
                                looks1.helmetcolor = "Gold";
                                break;
                            }
                            else if (helmcolorinput == 3)
                            {
                                looks1.helmetcolor = "Brown";
                                break;
                            }
                            else
                            {
                                Console.ForegroundColor = ConsoleColor.DarkRed;
                                Console.WriteLine("\t\t\t\t\t Invalid Input, Try Again!");
                                Console.ResetColor();
                            }
                        }
                        catch (FormatException e)
                        {
                            Console.ForegroundColor = ConsoleColor.DarkRed;
                            Console.WriteLine("\t\t\t\t\tInvalid String Input, Try Again!");
                            Console.ResetColor();
                        }
                    }
                    looks1.armorcolor = "";
                    while (true)
                    {
                        try
                        {
                            colorarmor.whatColor();
                            Console.ForegroundColor = ConsoleColor.DarkRed;
                            int armcolorinput = Convert.ToInt32(Console.ReadLine());
                            Console.ResetColor();
                            Console.WriteLine();
                            if (armcolorinput == 1)
                            {
                                looks1.armorcolor = "Silver";
                                break;
                            }
                            else if (armcolorinput == 2)
                            {
                                looks1.armorcolor = "Gold";
                                break;
                            }
                            else if (armcolorinput == 3)
                            {
                                looks1.armorcolor = "Brown";
                                break;
                            }
                            else
                            {
                                Console.ForegroundColor = ConsoleColor.DarkRed;
                                Console.WriteLine("\t\t\t\t\t Invalid Input, Try Again!");
                                Console.ResetColor();
                            }
                        }
                        catch (FormatException e)
                        {
                            Console.ForegroundColor = ConsoleColor.DarkRed;
                            Console.WriteLine("\t\t\t\t\tInvalid String Input, Try Again!");
                            Console.ResetColor();
                        }
                    }
                    looks1.accessories = "";
                    while (true)
                    {
                        try
                        {
                            Console.Write("\t\t      What Accessories do you want?(1.Horns, 2.Tails, 3.Claws, 4.Third Eye): ");
                            Console.ForegroundColor = ConsoleColor.DarkRed;
                            int accinput = Convert.ToInt32(Console.ReadLine());
                            Console.ResetColor();
                            Console.WriteLine();
                            if (accinput == 1)
                            {
                                looks1.accessories = "Horns";
                                break;
                            }
                            else if (accinput == 2)
                            {
                                looks1.accessories = "Tails";
                                break;
                            }
                            else if (accinput == 3)
                            {
                                looks1.accessories = "Claws";
                                break;
                            }
                            else if (accinput == 4)
                            {
                                looks1.accessories = "Third Eye";
                                break;
                            }
                            else
                            {
                                Console.ForegroundColor = ConsoleColor.DarkRed;
                                Console.WriteLine("\t\t\t\t\t Invalid Input, Try Again!");
                                Console.ResetColor();
                            }
                        }
                        catch (FormatException e)
                        {
                            Console.ForegroundColor = ConsoleColor.DarkRed;
                            Console.WriteLine("\t\t\t\t\tInvalid String Input, Try Again!");
                            Console.ResetColor();
                        }
                    }
                    //gameplay features
                    damage Damage = new damage();
                    matigas Reducton = new matigas();
                    kuripot less = new kuripot();
                    looks1.pet = "";
                    while (true)
                    {
                        try
                        {
                            Console.Write("\t\t\t    What kind of pet do you want?(1.Wolf, 2.Horse, 3.Boar): ");
                            Console.ForegroundColor = ConsoleColor.DarkRed;
                            int petinput = Convert.ToInt32(Console.ReadLine());
                            Console.ResetColor();
                            Console.WriteLine();
                            if (petinput == 1)
                            {
                                looks1.pet = "Wolf";
                                break;
                            }
                            else if (petinput == 2)
                            {
                                looks1.pet = "Horse";
                                break;
                            }
                            else if (petinput == 3)
                            {
                                looks1.pet = "Boar";
                                break;
                            }
                            else
                            {
                                Console.ForegroundColor = ConsoleColor.DarkRed;
                                Console.WriteLine("\t\t\t\t\t Invalid Input, Try Again!");
                                Console.ResetColor();
                            }
                        }
                        catch (FormatException e)
                        {
                            Console.ForegroundColor = ConsoleColor.DarkRed;
                            Console.WriteLine("\t\t\t\t\tInvalid String Input, Try Again!");
                            Console.ResetColor();
                        }
                    }
                    string location = "";
                    while (true)
                    {
                        try
                        {
                            Question lugar = new Question("    Which Town would you like to play on?(1.Nightless Desert, 2.Hextech City, 3.Hollow Town, 4.Seaside Riverdale): ");
                            lugar.display();
                            Console.ForegroundColor = ConsoleColor.DarkRed;
                            int locinput = Convert.ToInt32(Console.ReadLine());
                            Console.ResetColor();
                            Console.WriteLine();
                            if (locinput == 1)
                            {
                                location = "Nightless Desert";
                                break;
                            }
                            else if (locinput == 2)
                            {
                                location = "Hextech City";
                                break;
                            }
                            else if (locinput == 3)
                            {
                                location = "Hollow Town";
                                break;
                            }
                            else if (locinput == 4)
                            {
                                location = "Seaside Riverdale";
                                break;
                            }
                            else
                            {
                                Console.ForegroundColor = ConsoleColor.DarkRed;
                                Console.WriteLine("\t\t\t\t\t Invalid Input, Try Again!");
                                Console.ResetColor();
                            }
                        }
                        catch (FormatException e)
                        {
                            Console.ForegroundColor = ConsoleColor.DarkRed;
                            Console.WriteLine("\t\t\t\t\tInvalid String Input, Try Again!");
                            Console.ResetColor();
                        }
                    }
                    string perks = "";
                    while (true)
                    {
                        try
                        {
                            perk buff = new perk("          What perks do you wanna receive?(1.+5% Bonus Damage, 2.-5% Equipment Cost, 3. +5% Damage Reduction): ");
                            buff.Display();
                            Console.ForegroundColor = ConsoleColor.DarkRed;
                            int perkinput = Convert.ToInt32(Console.ReadLine());
                            Console.ResetColor();
                            Console.WriteLine();

                            if (perkinput == 1)
                            {
                                perks = "+5% Bonus Damage";
                                Damage.PerkMessage();
                                break;
                            }
                            else if (perkinput == 2)
                            {
                                perks = "-5% Equipment Cost";
                                less.PerkMessage();
                                break;
                            }
                            else if (perkinput == 3)
                            {
                                perks = "+5% Damage Reduction";
                                Reducton.PerkMessage();
                                break;
                            }
                            else
                            {
                                Console.ForegroundColor = ConsoleColor.DarkRed;
                                Console.WriteLine("\t\t\t\t\t Invalid Input, Try Again!");
                                Console.ResetColor();
                            }
                        }
                        catch (FormatException e)
                        {
                            Console.ForegroundColor = ConsoleColor.DarkRed;
                            Console.WriteLine("\t\t\t\t\tInvalid String Input, Try Again!");
                            Console.ResetColor();
                        }
                    }
                    Console.Clear();
                    Console.WriteLine("\t\t\t\t----------------------------------------------");
                    Console.WriteLine("          \t\t\t\tWelcome to Stats Distribution!");
                    Console.WriteLine("\t\t\t\t----------------------------------------------");
                    Stats stats;
                    while (true)
                    {
                        try
                        {
                            Console.WriteLine("\t\t\t\t\t  Put (7) Points to your stats.");
                            Console.WriteLine("\t\t\t  Stats List: 1.Power, 2.Defense, 3.Dexterity, 4.Intelligence");
                            stats.points = 7;
                            Console.Write("\t\t\t\t\t    Power(Adaptive Force): ");
                            Console.ForegroundColor = ConsoleColor.DarkRed;
                            stats.power = Convert.ToInt32(Console.ReadLine());
                            Console.ResetColor();
                            stats.points -= stats.power;
                            Console.WriteLine("\t\t\t\t\t        Points left: " + stats.points);
                            Console.Write("\t\t\t\t\t        Defense: ");
                            Console.ForegroundColor = ConsoleColor.DarkRed;
                            stats.defense = Convert.ToInt32(Console.ReadLine());
                            Console.ResetColor();
                            stats.points -= stats.defense;
                            Console.WriteLine("\t\t\t\t\t        Points left: " + stats.points);
                            Console.Write("\t\t\t\t\t        Dexterity: ");
                            Console.ForegroundColor = ConsoleColor.DarkRed;
                            stats.dexterity = Convert.ToInt32(Console.ReadLine());
                            Console.ResetColor();
                            stats.points -= stats.dexterity;
                            Console.WriteLine("\t\t\t\t\t        Points left: " + stats.points);
                            Console.Write("\t\t\t\t\t        Intelligence: ");
                            Console.ForegroundColor = ConsoleColor.DarkRed;
                            stats.intelligence = Convert.ToInt32(Console.ReadLine());
                            Console.ResetColor();
                            stats.points -= stats.intelligence;
                            Console.WriteLine("\t\t\t\t\t        Points left: " + stats.points);
                            if (stats.power < 0 || stats.defense < 0 || stats.dexterity < 0 || stats.intelligence < 0)
                            {
                                Console.ForegroundColor = ConsoleColor.DarkRed;
                                Console.WriteLine("\t\t\t\t\t  No negative integer please!");
                                Console.ResetColor();
                            }
                            else
                            {
                                if (stats.points == 0)
                                {
                                    break;

                                }
                                if (stats.points < stats.power && stats.points < stats.defense && stats.points < stats.dexterity && stats.points < stats.intelligence)
                                {
                                    Console.ForegroundColor = ConsoleColor.DarkRed;
                                    Console.WriteLine("\t\t\t\t\t   Not enough points, Try Again!");
                                    Console.ResetColor();
                                }
                                else if (stats.points > 0)
                                {
                                    Console.ForegroundColor = ConsoleColor.DarkRed;
                                    Console.WriteLine("\t\t\t\t     You have excess points of " + stats.points + " , Try Again!");
                                    Console.ResetColor();
                                }
                            }
                        }
                        catch (FormatException e)
                        {
                            Console.ForegroundColor = ConsoleColor.DarkRed;
                            Console.WriteLine("\t\t\t\t\t   Invalid Stat Input, Try Again!");
                            Console.ResetColor();
                        }
                    }
                    bool hellmode;
                    while (true)
                    {
                        try
                        {
                            Console.WriteLine("\t\tWould you like to play in Hell-Mode?(Enemies are 50% stronger, but they drop 50% more loot!");
                            Console.Write("\t\t\t\t\t\t 1.Yes / 2.No: ");
                            Console.ForegroundColor = ConsoleColor.DarkRed;
                            int hellchoice = Convert.ToInt32(Console.ReadLine());
                            Console.ResetColor();
                            if (hellchoice == 1)
                            {
                                hellmode = true;
                                break;
                            }
                            else if (hellchoice == 2)
                            {
                                hellmode = false;
                                break;
                            }
                        }
                        catch (FormatException e)
                        {
                            Console.ForegroundColor = ConsoleColor.DarkRed;
                            Console.WriteLine("\t\t\t\t\tInvalid String Input, Try Again!");
                            Console.ResetColor();
                        }
                    }
                    bool parasite;
                    string characterbuff;
                    Console.Clear();
                    Console.WriteLine("\t\t\t\t----------------------------------------------");
                    Console.WriteLine("          \t\t\t\tWelcome to The Storyline Phase!");
                    Console.WriteLine("\t\t\t\t----------------------------------------------");
                    Console.Write("\t\t    One day, our protagonist woke up in a random street, bleeding heavily.\n\t\t\t\t\tPress Enter to Continue. ");
                    string enter = Console.ReadLine();
                    Console.Write("\t\t  " + info.getName + " felt something very painful in " + info.getGender + " stomach that causes the protagonist to scream.\n \t\t\t\t\tPress Enter to Continue. ");
                    string enter1 = Console.ReadLine();
                    while (true)
                    {
                        try
                        {
                            Console.Write("\t\t    Do you want your character to have a parasite disease?(1.Yes/2.No): ");
                            Console.ForegroundColor = ConsoleColor.DarkRed;
                            int parasitecheck = Convert.ToInt32(Console.ReadLine());
                            Console.ResetColor();
                            if (parasitecheck == 1)
                            {
                                characterbuff = "Blood Rampage";
                                Console.Write("You gained an ability called 'Blood Rampage' that deals +10% Damage, and weakens your durability for -10% Damage Reduction.\n\t\t\t\t\tPress Enter to Continue.");
                                string enterrr = Console.ReadLine();
                                Console.Clear();
                                Console.Write("\t    " + info.getName + " looks at " + info.getGender + " stomach and saw a gruesome sight. A small parasite is crawling through " + info.getGender + " body.\n\t\t\t\t\tPress Enter to Continue. ");
                                string enter3 = Console.ReadLine();
                                Console.Clear();
                                Console.Write("\t    " + info.getName + " starts to pick " + info.getGender + " self up and went to the local church to consult to the priest for healings.\n\t\t\t\t\tPress Enter to Continue. ");
                                string enter4 = Console.ReadLine();
                                Console.Clear();
                                Console.Write("\t\t The priest take a look at " + info.getGender + " stomach and says 'You are beyond saving!, unless...'\n\t\t\t\t\tPress Enter to Continue.");
                                string enter5 = Console.ReadLine();
                                Console.Clear();
                                Console.Write("The priest gave " + info.getName + " a medicine and says 'Take this, this shall slow down the parasite from eating you alive, You must find the Forbidden Phantom Abyss(similar to one piece) before its too late!'\n\t\t\t\t\tPress Enter to Continue. ");
                                string enter6 = Console.ReadLine();
                                Console.Clear();
                                Console.Write("'But what should i do when i reached the cave?' " + info.getName + " utters. ");
                                Console.Write("The priest says 'There is a magical flower i need. I need it to kill the parasite inside you but, it only grows in that cave. Go on, you are running out of time!'\n\t\t\t\t\tPress Enter to Continue");
                                string enter7 = Console.ReadLine();
                                Console.Clear();
                                Console.WriteLine("\t\t" + info.getName + " embarks on a new adventure hoping to find the Lost Cave in order to save " + info.getGender + "self.");
                                break;
                            }
                            else if (parasitecheck == 2)
                            {
                                characterbuff = "+10% Damage";
                                Console.Write("\t\t\t\t\t You gained +10% Damage.\n\t\t\t\t\tPress Enter to Continue.");
                                string enterr = Console.ReadLine();
                                Console.Clear();
                                Console.Write(info.getName + " looked at " + info.getGender + " stomach and saw a very deep wound, and yet, the protagonist doesn't have an idea how it got " + info.getGender + " wounds because, the protagonist can't remember anything.\n\t\t\t\t\tPress Enter to Continue");
                                string enter8 = Console.ReadLine();
                                Console.Clear();
                                Console.Write("\t\t" + info.getName + " starts to pick " + info.getGender + " self up to go to the local church to consult to the priest for healings.\n\t\t\t\t\tPress Enter to Continue");
                                string enter9 = Console.ReadLine();
                                Console.Clear();
                                Console.Write("\t    " + info.getName + " then met the local priest and the priest healed " + info.getGender + " wounds, and asked what happened, and why " + info.getGender + " memories are gone.\n\t\t\t\t\tPress Enter to Continue");
                                string enter10 = Console.ReadLine();
                                Console.Clear();
                                Console.Write("The Priest says 'Well you have a deep wound, you must've fought a hard battle, but those several weeks, the town is very peaceful!'\n\t\t\t\t\tPress Enter to Continue");
                                string enter100 = Console.ReadLine();
                                Console.Clear();
                                Console.Write(info.getName + " looked very confused. The priest says 'I know someone who can help you from remembering your memories. But she is not a kind person!'\n\t\t\t\t\tPress Enter to Continue");
                                string enter11 = Console.ReadLine();
                                Console.Clear();
                                Console.Write(info.getName + " says 'I've got no choice, i guess...' ");
                                Console.Write("The priest says 'She is a witch, she lived near the Tower of Obsidian Veil, but be careful, she may kill you if you spat a wrong word.'\n\t\t\t\t\tPress Enter to Continue");
                                string enter12 = Console.ReadLine();
                                Console.Clear();
                                Console.WriteLine("     " + info.getName + " embarks on a new adventure looking for the Wicked Witch that may help our protagonist recall " + info.getGender + " missing memories.");
                                break;
                            }
                            else
                            {
                                Console.ForegroundColor = ConsoleColor.DarkRed;
                                Console.WriteLine("\t\t\t\t\t Invalid Input, Try Again!");
                                Console.ResetColor();
                            }
                        }
                        catch (FormatException e)
                        {
                            Console.ForegroundColor = ConsoleColor.DarkRed;
                            Console.WriteLine("\t\t\t\t\tInvalid Input, Try Again!");
                            Console.ResetColor();
                        }
                    }
                    while (true)
                    {
                        try
                        {
                            Console.WriteLine("\t\t\t------------------------------------------------------------------");
                            Console.Write("\t\t\t      Do you wanna print all your information?(1.Yes / 2.No): ");
                            Console.ForegroundColor = ConsoleColor.DarkRed;
                            int anothachoice = Convert.ToInt32(Console.ReadLine());
                            Console.ResetColor();
                            if (anothachoice == 1)
                            {
                                Console.Clear();
                                Console.WriteLine("\t\t\t\t    -------------------------------------------------");
                                Console.WriteLine("\t\t\t\t                      Information List");
                                Console.WriteLine("\t\t\t\t    -------------------------------------------------");
                                Console.Write("\t\t\t\t    Your name is: ");
                                Console.ForegroundColor = ConsoleColor.DarkRed;
                                Console.WriteLine(info.getName);
                                Console.ResetColor();
                                Console.Write("\t\t\t\t    Your sex is: ");
                                Console.ForegroundColor = ConsoleColor.DarkRed;
                                Console.WriteLine(info.getSex);
                                Console.ResetColor();
                                Console.Write("\t\t\t\t    Your character class is: ");
                                Console.ForegroundColor = ConsoleColor.DarkRed;
                                Console.WriteLine(info.getCharClass);
                                Console.ResetColor();
                                Console.Write("\t\t\t\t    Your Body Type is: ");
                                Console.ForegroundColor = ConsoleColor.DarkRed;
                                Console.WriteLine(info.getBody);
                                Console.ResetColor();
                                Console.Write("\t\t\t\t    Your species is: ");
                                Console.ForegroundColor = ConsoleColor.DarkRed;
                                Console.WriteLine(info.getSpecies);
                                Console.ResetColor();
                                Console.Write("\t\t\t\t    Your hair type is: ");
                                Console.ForegroundColor = ConsoleColor.DarkRed;
                                Console.WriteLine(hairtype);
                                Console.ResetColor();
                                Console.Write("\t\t\t\t    Your hair color is: ");
                                Console.ForegroundColor = ConsoleColor.DarkRed;
                                Console.WriteLine(haircolor);
                                Console.ResetColor();
                                Console.Write("\t\t\t\t    Your eye color is: ");
                                Console.ForegroundColor = ConsoleColor.DarkRed;
                                Console.WriteLine(looks1.eyecolors);
                                Console.ResetColor();
                                Console.Write("\t\t\t\t    Your skin color is: ");
                                Console.ForegroundColor = ConsoleColor.DarkRed;
                                Console.WriteLine(looks1.skincolors);
                                Console.ResetColor();
                                Console.Write("\t\t\t\t    Your Mouth type is: ");
                                Console.ForegroundColor = ConsoleColor.DarkRed;
                                Console.WriteLine(looks1.mouth);
                                Console.ResetColor();
                                Console.Write("\t\t\t\t    Your Helmet is: ");
                                Console.ForegroundColor = ConsoleColor.DarkRed;
                                Console.WriteLine(looks1.helmet);
                                Console.ResetColor();
                                Console.Write("\t\t\t\t    Your Armor is: ");
                                Console.ForegroundColor = ConsoleColor.DarkRed;
                                Console.WriteLine(looks1.armor);
                                Console.ResetColor();
                                Console.Write("\t\t\t\t    Your Helmet Color is: ");
                                Console.ForegroundColor = ConsoleColor.DarkRed;
                                Console.WriteLine(looks1.helmetcolor);
                                Console.ResetColor();
                                Console.Write("\t\t\t\t    Your Armor Color is: ");
                                Console.ForegroundColor = ConsoleColor.DarkRed;
                                Console.WriteLine(looks1.armorcolor);
                                Console.ResetColor();
                                Console.Write("\t\t\t\t    Your Accessories is: ");
                                Console.ForegroundColor = ConsoleColor.DarkRed;
                                Console.WriteLine(looks1.accessories);
                                Console.ResetColor();
                                Console.Write("\t\t\t\t    Your pet is: ");
                                Console.ForegroundColor = ConsoleColor.DarkRed;
                                Console.WriteLine(looks1.pet);
                                Console.ResetColor();
                                Console.Write("\t\t\t\t    Your Town Location is: ");
                                Console.ForegroundColor = ConsoleColor.DarkRed;
                                Console.WriteLine(location);
                                Console.ResetColor();
                                Console.Write("\t\t\t\t    Your perk is: ");
                                Console.ForegroundColor = ConsoleColor.DarkRed;
                                Console.WriteLine(perks);
                                Console.ResetColor();
                                Console.Write("\t\t\t\t    Is Hell-Mode Activated?: ");
                                Console.ForegroundColor = ConsoleColor.DarkRed;
                                Console.WriteLine(hellmode);
                                Console.ResetColor();
                                Console.Write("\t\t\t\t    Your Character Buff based on Storyline is: ");
                                Console.ForegroundColor = ConsoleColor.DarkRed;
                                Console.WriteLine(characterbuff);
                                Console.ResetColor();
                                Console.WriteLine("\t\t\t\t    -------------------------------------------------");
                                Console.WriteLine("\t\t\t\t                      STATS LIST");
                                Console.WriteLine("\t\t\t\t    -------------------------------------------------");
                                Console.Write("\t\t\t\t    Power: ");
                                Console.ForegroundColor = ConsoleColor.DarkRed;
                                Console.WriteLine(stats.power);
                                Console.ResetColor();
                                Console.Write("\t\t\t\t    Defense: ");
                                Console.ForegroundColor = ConsoleColor.DarkRed;
                                Console.WriteLine(stats.defense);
                                Console.ResetColor();
                                Console.Write("\t\t\t\t    Dexterity: ");
                                Console.ForegroundColor = ConsoleColor.DarkRed;
                                Console.WriteLine(stats.dexterity);
                                Console.ResetColor();
                                Console.Write("\t\t\t\t    Intelligence: ");
                                Console.ForegroundColor = ConsoleColor.DarkRed;
                                Console.WriteLine(stats.intelligence);
                                Console.ResetColor();
                                do
                                {
                                    try
                                    {
                                        Console.Write("\t\t\t\t    Do you wanna return to the main menu? 1.Yes, 2.No: ");
                                        c1 = Convert.ToInt32(Console.ReadLine());
                                        if (c1 == 1)
                                        {
                                            break;
                                        }
                                        else if (c1 == 2)
                                        {
                                            Environment.Exit(0);
                                        }
                                        else
                                        {
                                            Console.ForegroundColor = ConsoleColor.DarkRed;
                                            Console.WriteLine("\t\t\t\t\t  Invalid Input, Try Again!");
                                            Console.ResetColor();
                                        }
                                    }
                                    catch (FormatException e)
                                    {
                                        Console.ForegroundColor = ConsoleColor.DarkRed;
                                        Console.WriteLine("\t\t\t\t\t  Invalid String Input, Try Again!");
                                        Console.ResetColor();
                                    }

                                }
                                while (c1 < 2 || c1 > 0);
                                break;
                            }
                            else if (anothachoice == 2)
                            {
                                break;
                            }
                            else
                            {
                                Console.ForegroundColor = ConsoleColor.DarkRed;
                                Console.WriteLine("\t\t\t\t\tInvalid Input, Try Again!");
                                Console.ResetColor();
                            }
                        }
                        catch (FormatException e)
                        {
                            Console.ForegroundColor = ConsoleColor.DarkRed;
                            Console.WriteLine("\t\t\t\t\tInvalid String Input, Try Again!");
                            Console.ResetColor();
                        }
                    }
                    string insertQueryString = "INSERT INTO dbo.Character_Information (name, sex, class, body, species, hair_type, hair_color, eye_color, skin_color, mouth, helmet, armor, helmet_color, armor_color, accessories, pet, location, perks, character_buff, power, defense, dexterity, intelligence, hellmode) VALUES ('" + info.getName + "', '" + info.getSex + "', '" + info.getCharClass + "', '" + info.getBody + "', '" + info.getSpecies + "', '" + hairtype + "', '" + haircolor + "', '" + looks1.eyecolors + "', '" + looks1.skincolors + "', '" + looks1.mouth + "', '" + looks1.helmet + "', '" + looks1.armor + "', '" + looks1.helmetcolor + "', '" + looks1.armorcolor + "', '" + looks1.accessories + "', '" + looks1.pet + "', '" + location + "', '" + perks + "', '" + characterbuff + "', '" + stats.power + "', '" + stats.defense + "', '" + stats.dexterity + "', '" + stats.intelligence + "', '" + boolConverter(hellmode) + "')";

                    SqlCommand insertDataPuhliz = new SqlCommand(insertQueryString, sqlConnectMoKoMamSir);
                    insertDataPuhliz.ExecuteNonQuery();
                }
                else if (nick == 2)
                {
                    Console.Clear();
                    int choice = 0;
                    while (true)
                    {
                        do
                        {
                            Console.WriteLine("\t\t\t\t\t  Please choose your action:\n\t\t\t\t\t  1.Display Database Info \n\t\t\t\t\t  2.Delete a Data from the Database \n\t\t\t\t\t  3.Go back to main menu \n\t\t\t\t\t  4.Exit Program ");
                            try
                            {
                                Console.Write("\t\t\t\t\t  Choice: ");
                                Console.ForegroundColor = ConsoleColor.DarkRed;
                                choice = Convert.ToInt32(Console.ReadLine());
                                Console.ResetColor();
                                if (choice > 4 || choice < 0)
                                {
                                    Console.ForegroundColor = ConsoleColor.DarkRed;
                                    Console.WriteLine("\t\t\t\t\tInvalid Input, Try Again!");
                                    Console.ResetColor();

                                }
                            }
                            catch (Exception e)
                            {
                                Console.ForegroundColor = ConsoleColor.DarkRed;
                                Console.WriteLine("\t\t\t\t\tInvalid Input, Try Again!");
                                Console.ResetColor();
                            }

                        }
                        while (choice > 4 || choice < 0);
                        if (choice == 1)
                        {
                            string sqlQuery = "SELECT character_id, name, sex, class, body, species, hair_type, hair_color, eye_color, skin_color, mouth, helmet, armor, helmet_color, armor_color, accessories, pet, location, perks, character_buff, power, defense, dexterity, intelligence, hellmode FROM Character_Information";
                            using (SqlCommand cmd = new SqlCommand(sqlQuery, sqlConnectMoKoMamSir))
                            {
                                try
                                {
                                    using (SqlDataReader dataReader = cmd.ExecuteReader())
                                    {
                                        Console.WriteLine("\t\t\t\t    Data from the Database..");
                                        while (dataReader.Read())
                                        {
                                            Console.ForegroundColor = ConsoleColor.Green;
                                            Console.WriteLine("------------------------------------------------------------------------------------------------------------------------");
                                            Console.WriteLine("------------------------------------------------------------------------------------------------------------------------");
                                            Console.ResetColor();
                                            Console.Write("\t\t\t\t    Character ID: ");
                                            Console.ForegroundColor = ConsoleColor.DarkRed;
                                            Console.WriteLine(dataReader["character_id"]);
                                            Console.ResetColor();
                                            Console.WriteLine("");
                                            Console.Write("\t\t\t\t    Name: ");
                                            Console.ForegroundColor = ConsoleColor.DarkRed;
                                            Console.WriteLine(dataReader.GetValue(1));
                                            Console.ResetColor();
                                            Console.Write("\t\t\t\t    Sex: ");
                                            Console.ForegroundColor = ConsoleColor.DarkRed;
                                            Console.WriteLine(dataReader.GetValue(2));
                                            Console.ResetColor();
                                            Console.Write("\t\t\t\t    Class: ");
                                            Console.ForegroundColor = ConsoleColor.DarkRed;
                                            Console.WriteLine(dataReader.GetValue(3));
                                            Console.ResetColor();
                                            Console.Write("\t\t\t\t    Body: ");
                                            Console.ForegroundColor = ConsoleColor.DarkRed;
                                            Console.WriteLine(dataReader.GetValue(4));
                                            Console.ResetColor();
                                            Console.Write("\t\t\t\t    Species: ");
                                            Console.ForegroundColor = ConsoleColor.DarkRed;
                                            Console.WriteLine(dataReader.GetValue(5));
                                            Console.ResetColor();
                                            Console.Write("\t\t\t\t    Hair Type: ");
                                            Console.ForegroundColor = ConsoleColor.DarkRed;
                                            Console.WriteLine(dataReader.GetValue(6));
                                            Console.ResetColor();
                                            Console.Write("\t\t\t\t    Hair Color: ");
                                            Console.ForegroundColor = ConsoleColor.DarkRed;
                                            Console.WriteLine(dataReader.GetValue(7));
                                            Console.ResetColor();
                                            Console.Write("\t\t\t\t    Eye Color: ");
                                            Console.ForegroundColor = ConsoleColor.DarkRed;
                                            Console.WriteLine(dataReader.GetValue(8));
                                            Console.ResetColor();
                                            Console.Write("\t\t\t\t    Skin Color: ");
                                            Console.ForegroundColor = ConsoleColor.DarkRed;
                                            Console.WriteLine(dataReader.GetValue(9));
                                            Console.ResetColor();
                                            Console.Write("\t\t\t\t    Mouth: ");
                                            Console.ForegroundColor = ConsoleColor.DarkRed;
                                            Console.WriteLine(dataReader.GetValue(10));
                                            Console.ResetColor();
                                            Console.Write("\t\t\t\t    Helmet: ");
                                            Console.ForegroundColor = ConsoleColor.DarkRed;
                                            Console.WriteLine(dataReader.GetValue(11));
                                            Console.ResetColor();
                                            Console.Write("\t\t\t\t    Armor: ");
                                            Console.ForegroundColor = ConsoleColor.DarkRed;
                                            Console.WriteLine(dataReader.GetValue(12));
                                            Console.ResetColor();
                                            Console.Write("\t\t\t\t    Helmet Color: ");
                                            Console.ForegroundColor = ConsoleColor.DarkRed;
                                            Console.WriteLine(dataReader.GetValue(13));
                                            Console.ResetColor();
                                            Console.Write("\t\t\t\t    Armor Color: ");
                                            Console.ForegroundColor = ConsoleColor.DarkRed;
                                            Console.WriteLine(dataReader.GetValue(14));
                                            Console.ResetColor();
                                            Console.Write("\t\t\t\t    Accessories: ");
                                            Console.ForegroundColor = ConsoleColor.DarkRed;
                                            Console.WriteLine(dataReader.GetValue(15));
                                            Console.ResetColor();
                                            Console.Write("\t\t\t\t    Pet: ");
                                            Console.ForegroundColor = ConsoleColor.DarkRed;
                                            Console.WriteLine(dataReader.GetValue(16));
                                            Console.ResetColor();
                                            Console.Write("\t\t\t\t    Location: ");
                                            Console.ForegroundColor = ConsoleColor.DarkRed;
                                            Console.WriteLine(dataReader.GetValue(17));
                                            Console.ResetColor();
                                            Console.Write("\t\t\t\t    Perks: ");
                                            Console.ForegroundColor = ConsoleColor.DarkRed;
                                            Console.WriteLine(dataReader.GetValue(18));
                                            Console.ResetColor();
                                            Console.Write("\t\t\t\t    Character Buff: ");
                                            Console.ForegroundColor = ConsoleColor.DarkRed;
                                            Console.WriteLine(dataReader.GetValue(19));
                                            Console.ResetColor();
                                            Console.Write("\t\t\t\t    Power: ");
                                            Console.ForegroundColor = ConsoleColor.DarkRed;
                                            Console.WriteLine(dataReader.GetValue(20));
                                            Console.ResetColor();
                                            Console.Write("\t\t\t\t    Defense: ");
                                            Console.ForegroundColor = ConsoleColor.DarkRed;
                                            Console.WriteLine(dataReader.GetValue(21));
                                            Console.ResetColor();
                                            Console.Write("\t\t\t\t    Dexterity: ");
                                            Console.ForegroundColor = ConsoleColor.DarkRed;
                                            Console.WriteLine(dataReader.GetValue(22));
                                            Console.ResetColor();
                                            Console.Write("\t\t\t\t    Intelligence: ");
                                            Console.ForegroundColor = ConsoleColor.DarkRed;
                                            Console.WriteLine(dataReader.GetValue(23));
                                            Console.ResetColor();
                                            Console.Write("\t\t\t\t    Hell-Mode Gameplay: ");
                                            Console.ForegroundColor = ConsoleColor.DarkRed;
                                            Console.WriteLine(dataReader.GetValue(24));
                                            Console.ResetColor();
                                        }
                                    }
                                }
                                catch (Exception ex)
                                {
                                    Console.WriteLine($"Error: {ex.Message}");
                                }
                            }
                        }
                        else if (choice == 2)
                        {
                            try
                            {
                                string DELETING = "DELETE FROM dbo.Character_Information WHERE character_id = @SELECT";
                                Console.Write("\t\t\t\tSelect Which Data Do You want to delete: ");
                                SqlCommand cmds = new SqlCommand(DELETING, sqlConnectMoKoMamSir);
                                Console.ForegroundColor = ConsoleColor.DarkRed;
                                int Select = Convert.ToInt32(Console.ReadLine());
                                Console.ResetColor();
                                while (true)
                                {
                                    try
                                    {
                                        Console.Write("\t\t\t Are you sure you want to delete character: " + Select + "?(Y/N): ");
                                        Console.ForegroundColor = ConsoleColor.DarkRed;
                                        string delchar = Console.ReadLine();
                                        Console.ResetColor();
                                        if (delchar == "Y" || delchar == "y")
                                        {
                                            cmds.Parameters.AddWithValue("@SELECT", Select);
                                            int rowAffected = cmds.ExecuteNonQuery();
                                            if (rowAffected > 0)
                                            {
                                                Console.ForegroundColor = ConsoleColor.Green;
                                                Console.WriteLine("\t\t\t\tData Has Been Deleted");
                                                Console.ResetColor();
                                                break;
                                            }
                                            else
                                            {
                                                Console.ForegroundColor = ConsoleColor.Green;
                                                Console.WriteLine("\t\t\t\tNo data found");
                                                Console.ResetColor();
                                                break;
                                            }
                                        }
                                        else if (delchar == "N" || delchar == "n")
                                        {
                                            break;
                                        }
                                        else
                                        {
                                            Console.ForegroundColor = ConsoleColor.DarkRed;
                                            Console.WriteLine("\t\t\t\tInvalid Input, Try Again!");
                                            Console.ResetColor();
                                        }
                                    }
                                    catch (FormatException e)
                                    {
                                        Console.ForegroundColor = ConsoleColor.DarkRed;
                                        Console.WriteLine("\t\t\t\t\tInvalid String Input, Try Again!");
                                        Console.ResetColor();
                                    }
                                }
                                Console.Write("\t\t\t\tDo you wanna go back to the menu?(Y/N): ");
                                Console.ForegroundColor = ConsoleColor.DarkRed;
                                string choices = Console.ReadLine();
                                Console.ResetColor();
                                if (choices == "Y" || choices == "y")
                                {

                                }
                                else if (choices == "N" || choices == "n")
                                {
                                    Environment.Exit(0);
                                }
                                else
                                {
                                    Console.ForegroundColor = ConsoleColor.DarkRed;
                                    Console.WriteLine("\t\t\t\tInvalid Input, Try Again!");
                                    Console.ResetColor();
                                }
                            }
                            catch (Exception e)
                            {
                                Console.WriteLine("\t\t\t\t" + e.Message);
                                Console.ResetColor();
                            }
                        }
                        else if (choice == 3)
                        {
                            break;
                        }
                        else if (choice == 4)
                        {
                            Environment.Exit(0);
                        }
                    }
                }
                else if (nick == 3)
                {
                    Environment.Exit(0);
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("\t\t\t\t\t  Invalid Input, Try Again!");
                    Console.ResetColor();
                }
            }
            catch (FormatException e)
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("\t\t\t\t\t  Invalid Input, Try Again!");
                Console.ResetColor();
            }
        }
    }
    static int boolConverter(bool kahitano)
    {
        if (kahitano) return 1;
        return 0;
    }
}
struct Stats
{
    public int points;
    public int power;
    public int defense;
    public int dexterity;
    public int intelligence;
}
public class Question
{
    public string skwater;
    public Question(string skwater)
    {
        this.skwater = skwater;
    }
    public void display()
    {
        Console.Write(skwater);
    }
}
public class perk
{
    public string pampalakas;
    public perk(string pampalakas)
    {
        this.pampalakas = pampalakas;
    }
    public void Display()
    {
        Console.Write(pampalakas);
    }
}