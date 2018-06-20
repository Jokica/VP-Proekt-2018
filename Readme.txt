#Windows Forms project by Jovan Gjorgiev ,Jovica Ilievski####



##1 Опис на апликацијата :
Апликацијата која ја развивавме е едностанва апликација за ресторан.
За да ја користите мора да се логирате со име и лозинка односно да бидете корисник.За да станете корисник треба само да пополните едноставна форма "Sign up".
Откако ке се логирате се појавува ново прозорце во кое има информации за неделните промоци за пијалок и храна како и резервациите кој ги имате направено.
Кога ке ја отворите апликацијата за прв пат ке се наогате во home.Со притискање на Reservation ке ви се покаже форма за пополнување доколку сакате да направите резервација.Други можности ви е Мену во која ви се отвара нова форма во која може да изберете дали сакате да го видите менито за пијалоци или за храна.
При притисок  на Абоут копчето се отвара About page за ресторанот.Како дел од оваа апликација имаме и мини игра сложувалка која може да ја отворите кога ке притиснете на "Play our game" .









Главни класи:
 public class Reservations
    {
        public Reservations(string name, bool smokers, int tableFor, DateTime date)
        {
            Name = name;
            Smokers = smokers;
            TableFor = tableFor;
            Date = date;
        }
        	//Име на која е направена резервацијата
        public string Name { set; get; }
        //Дали ке има пушачи
        public bool Smokers { get; set; }
        //Маса за колку луѓе
        public int TableFor { get; set; }
        //Кога е резервацијата
        public DateTime Date { set; get; }
      

        public override string ToString()
        {
            return string.Format("Name:{0} Time: {1} Table for {2} ", Name
                , Date, TableFor);
        }
    }
  Која претставува резервација 

  Класите User i Users Кој манеџираат дали некој е корисник или не:
  {
   public class User
    {
        public string userName { set; get; }
        public string Email { set; get; }

        public int Age { get; set; }
        public string password { get; set; }

        public User(string userName,string Email,int Age,string password)
        {
            this.userName = userName;
            this.Email = Email;
            this.Age = Age;
            this.password = password;
        }
        public bool isUser(String name,String pass)
        {
            return name == userName && password == pass;
        }
    }
}

public class Users
    {
    	//Lista od site korisnici
        LinkedList<User> users;
        public Users()
        {
            users = new LinkedList<User>();
        }
        public void addUser(User user)
        {
            users.AddLast(user);
        }
        //Dali Postoi nekoj korisnik so toa ime i passvord
        public bool shouldLogin(string name,string pass)
        {
            foreach(User user in users)
            {
                if (user.isUser(name, pass)) return true;
            }
            return false;
        }
    }

    #### shouldLogin funkcija koja vraka true dokolku postoi korisnik so toa ime i pass

    Битна класа за мини играта е MyPictureBox која наследува од PictureBox во која е додадено index и imageIndex  за да може да се прави споредба.

       class MyPictureBox:PictureBox
    {
        int index = 0;
        int imageIndex = 0;

        public int Index { get => index; set => index = value; }
        public int ImageIndex { get => imageIndex; set => imageIndex = value; }

        public bool isMatch()
        {
            return (index == imageIndex);
        }
    }
    За овој проект искористивме 6 форми и 4 класи.


   #################