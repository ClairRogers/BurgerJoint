namespace BurgerJoint.Models
{
  class Entree : Food
  {
    public int ComboNum { get; set; }



    public Entree(string name, float price, int combonum) : base(name, price)
    {
      ComboNum = combonum;
    }
  }
}