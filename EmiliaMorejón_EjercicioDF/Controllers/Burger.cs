using System.ComponentModel.DataAnnotations;

namespace EmiliaMorejon_CFEjercicio.Models
{
    public class Burger

    {
        public int Id { get; set; }
        [Required]
        public string? Name { get; set; }
        public bool Salsas { get; set; }
        [Range(0.01, 9999.99)]
        public decimal Precio { get; set; }

        private IMediator _mediator;

        public Burger(IMediator mediator)
        {
            _mediator = mediator;
        }

        public void UpdateName(string name)
        {
            _mediator.Send(name, "updateName");
        }

        public void UpdateSalsas(bool salsas)
        {
            _mediator.Send(salsas, "updateSalsas");
        }

        public void UpdatePrecio(decimal precio)
        {
            _mediator.Send(precio, "updatePrecio");
        }
    }

    public interface IMediator
    {
        void Send(object sender, string message);
    }

    public class ConcreteMediator : IMediator
    {
        private Burger _burger;

        public ConcreteMediator(Burger burger)
        {
            _burger = burger;
        }

        public void Send(object sender, string message)
        {
            switch (message)
            {
                case "updateName":
                    _burger.Name = (string)sender;
                    break;
                case "updateSalsas":
                    _burger.Salsas = (bool)sender;
                    break;
                case "updatePrecio":
                    _burger.Precio = (decimal)sender;
                    break;
            }
        }
    }
}
