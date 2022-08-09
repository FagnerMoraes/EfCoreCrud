using EfCoreCrud.Data;
using EfCoreCrud.Models;

using var context = new AppDbContext();

var todo = new Todo
{
    Id = 1,
    Title = "Ir ao mercado",
    Done = false
};

context.Todos.Add(todo);
context.SaveChanges();

var todos = context.Todos
    .Where(x => x.Done == false)
    .ToList();


foreach(var iten in todos)
{
     if(iten == null){
        Console.WriteLine("Banco Vazio");
    }else{
        Console.WriteLine(iten.Title);
    Console.WriteLine(iten.CreatedAt);
    }
}

var todoUpdate = context.Todos.FirstOrDefault(x => x.Id == 1);

todoUpdate.Title = "Ir a Academia";
context.Todos.Update(todoUpdate);
context.SaveChanges();


foreach(var iten in todos)
{
     if(iten == null){
        Console.WriteLine("Banco Vazio");
    }else{
        Console.WriteLine(iten.Title);
    Console.WriteLine(iten.CreatedAt);
    }
}

var todoDelete = context.Todos.FirstOrDefault(x => x.Id == 1);


context.Todos.Remove(todoDelete);
context.SaveChanges();

var tds = context.Todos.ToList();


foreach(var iten in tds){
        Console.WriteLine(iten.Title);
        Console.WriteLine(iten.CreatedAt);    
}