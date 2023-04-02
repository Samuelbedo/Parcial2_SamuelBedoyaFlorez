namespace TicketSystem.DAL.Entities
{
    public class SeederDb
    {
        private readonly DataBaseContext _context;

        public SeederDb(DataBaseContext context)
        {
            _context = context;
        }

        public async Task SeederAsync()
        {
            await _context.Database.EnsureCreatedAsync(); // me reemplaza el comando update-database
            await PopulateTicketsAsync();

            await _context.SaveChangesAsync();
        }

        private async Task PopulateTicketsAsync()
        {
            if (!_context.Tickets.Any())
            {
                for (int i = 0; i < 5; i++)
                {
                    _context.Tickets.Add(new Ticket { UseDate = null, IsUsed = false, EntranceGate = null});
                }
            }


        }
    }
}
