using Microsoft.AspNet.Mvc;

[Route("[controller]")]
public class GreetController  
{
    [Route("{name}")]
    public string Get(string name){
        return $"Hello {name}";
    }

    [HttpPost]
    public IActionResult CreateGreeting([FromBody]GreetDTO greeting){
        return new CreatedAtActionResult("Get","Greet", new { name = greeting.Message }, "Greeting created ya'll!");
    }
}

public class GreetDTO  
{
    public string Message { get; set; }
}