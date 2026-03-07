using codefirstefdemo;
using codefirstefdemo.Data;
using codefirstefdemo.Models;
using Microsoft.EntityFrameworkCore;


//var context=new AppDBContext();

//var electronics = new Category { Name = "Electronics" };

//context.Categories.Add(electronics);
//await context.SaveChangesAsync();

//context.Products.AddRange(
//    new Product { Name = "Laptop", Price = 999.67M, category = electronics },
//     new Product { Name = "Mouse", Price = 567.89M, category = electronics }

//);

//    await context.SaveChangesAsync();

//var laptop = await context.Products.FirstAsync(p=>p.Name=="Laptop");
//laptop.Price = 4567.88M;
//await context.SaveChangesAsync();

//context.Products.Remove(laptop);
//context.SaveChangesAsync();

//var authors = await context.Authors.Include(x => x.Courses).ToListAsync();

//foreach (var author in authors)
//{
//    Console.WriteLine($"Author: {author.Name}");
//    foreach(var course in author.Courses)
//    {
//        Console.WriteLine($"--{course.Title}--{course.Description}--{course.level}");
//    }
//}

var context = new AppDBContext();

//var newProduct = new Product { Name = "smartphone", Price = 6888.56M, CategoryId = 3};
IProductRepository  obj=new ProductRepository(context);
//await obj.AddAsync(newProduct);

//var toupdate = await obj.GetByIdAsync(newProduct.Id);
//if(toupdate != null)
//{
//    toupdate.Price = 777.67M;
//    toupdate.Name = "normalphone";
//   await obj.UpdateAsync(toupdate);
//    Console.WriteLine($"Updated : {toupdate.Name}--{toupdate.Price}");

//}

//var producttofetch = await obj.GetByIdAsync(7);
//if(producttofetch != null)
//{
//    producttofetch.Price = 55.67M;
//    producttofetch.Name = "normalphone2";
//    await obj.UpdateAsync(producttofetch);
//    Console.WriteLine($"Updated : {producttofetch.Name}--{producttofetch.Price}");

//}

await obj.DeleteAsync(7);





