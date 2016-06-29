using System.Collections.Generic;

namespace Tamagotchi.Objects
{
  public class Pet
  {
    private string _name;
    private int _food = 10;
    private int _play = 10;
    private int _sleep = 10;
    private bool _isAlive = true;
    private static List<Pet> _pet = new List<Pet> {};
    public Pet (string name)
    {
      _name = name;
    }
    public string GetName()
    {
      return _name;
    }
    public void SetName(string newName)
    {
      _name = newName;
    }
    public int GetFood()
    {
      return _food;
    }
    public void SetFood(int newFood)
    {
      _food = newFood;
    }
    public void FeedPet()
    {
      _food ++;
    }
    public int GetPlay()
    {
      return _play;
    }
    public void SetPlay(int newPlay)
    {
      _play = newPlay;
    }
    public int GetSleep ()
    {
      return _sleep;
    }
    public void SetSleep(int newSleep)
    {
      _sleep = newSleep;
    }
    public bool GetState()
    {
      return _isAlive;
    }
    public static List<Pet> GetAll()
    {
      return _pet;
    }
    public void Save()
    {
      _pet.Add(this);
    }
    public void MakeTimePass()
    {
      if (_food > 0)
      {
        _food --;
      }
      else if (_food == 0 && _food <= 0)
      {
        this._isAlive = false;
      }
    }
  }
}
