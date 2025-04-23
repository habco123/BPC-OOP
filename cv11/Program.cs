using Microsoft.EntityFrameworkCore;
using cv11.EFCore;
using (var context = new Vyukacontext())
{
    context.Database.Migrate();
}


