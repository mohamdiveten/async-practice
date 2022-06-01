using System;

namespace ConsoleApp
{
    internal class Bacon
    {
        public string Id { get; set; }

        public string Name { get; set; }
        public Bacon() : this(String.Empty)
        {
            // no two bacons are created equal
          
        }
        public Bacon(string name) {
            // no two bacons are created equal
            Id = Guid.NewGuid().ToString();
            Name = name; 
        }

    }

   public class BaconDto
    {
        private Bacon _baconInternal { get; set; } = new Bacon();
        public string Id => _baconInternal.Id;
        public string Name=> _baconInternal?.Name;


        public override bool Equals(object obj)
        {   
            if (obj == null) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != GetType()) return false;
            if(((BaconDto)obj)?.Id == Id) return true;
  
            return base.Equals(obj);
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Id);
        }
    }
}