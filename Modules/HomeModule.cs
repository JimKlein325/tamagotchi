using Nancy;
using System.Collections.Generic;
using Tamagotchi.Objects;

namespace Tamagotchi
{
  public class HomeModule : NancyModule
  {
    public HomeModule()
    {
      Get ["/"] = _ => View ["pet_form.cshtml"];
      Post ["/pet"] = _ => {
        Pet newPet = new Pet
        (
        Request.Form["petName"]
        );
        return View ["pet.cshtml", newPet];
      };
    }
  }
}
