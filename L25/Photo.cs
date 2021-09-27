using System;


namespace L25
{

    [Geo(20, 20)]
        
    public class Photo
    {

        public string Name { get; set; }

        public string Path { get; set; }
        
        public Photo(string name)
        {

            // проверка 

            Name = name;
        }
    }
}
