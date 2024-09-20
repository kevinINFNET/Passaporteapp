using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using PessoaPassaporteApp.Models;

namespace PessoaPassaporteApp.Pages.Pessoas
{
    public class IndexModel : PageModel
    {
        private readonly AppDbContext _context;

        public IndexModel(AppDbContext context)
        {
            _context = context;
        }

        public IList<Pessoa> Pessoas { get; set; }

        public async Task OnGetAsync()
        {
            Pessoas = await _context.Pessoas.Include(p => p.Passaporte).ToListAsync();
        }
    }
}
