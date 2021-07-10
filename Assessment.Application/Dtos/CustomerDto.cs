using System;
namespace Assessment.Application.Dtos
{
    public class CustomerDto
    {

        public int Id { get; set; }
        public string Rfc { get; set; }
        public string Name { get; set; }
        public string CorporateName { get; set; }
        public bool Active { get; set; }


        public CustomerDto()
        {
        }

    }
}
