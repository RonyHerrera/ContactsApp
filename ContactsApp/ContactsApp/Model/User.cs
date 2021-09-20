using System;
using System.Collections.Generic;
using System.Text;

namespace ContactsApp.Model
{

        public partial class JsonDataModel
        {
            public List<Result> Results { get; set; }
            public Info Info { get; set; }
        }

        public partial class Info
        {
            public string Seed { get; set; }
            public long Results { get; set; }
            public long Page { get; set; }
            public string Version { get; set; }
        }

        public partial class Result
        {
            public string Gender { get; set; }
            public Name Name { get; set; }
            public string Email { get; set; }
            public Login Login { get; set; }
            public Dob Dob { get; set; }
            public Dob Registered { get; set; }
            public string Phone { get; set; }
            public string Cell { get; set; }
            public Id Id { get; set; }
            public Picture Picture { get; set; }
            public string Nat { get; set; }
        }

        public partial class Dob
        {
            public DateTimeOffset Date { get; set; }
            public long Age { get; set; }
        }

        public partial class Id
        {
            public string Name { get; set; }
            public string Value { get; set; }
        }


        public partial class Coordinates
        {
            public string Latitude { get; set; }
            public string Longitude { get; set; }
        }

        public partial class Timezone
        {
            public string Offset { get; set; }
            public string Description { get; set; }
        }

        public partial class Login
        {
            public Guid Uuid { get; set; }
            public string Username { get; set; }
            public string Password { get; set; }
            public string Salt { get; set; }
            public string Md5 { get; set; }
            public string Sha1 { get; set; }
            public string Sha256 { get; set; }
        }

        public partial class Name
        {
            public string Title { get; set; }
            public string First { get; set; }
            public string Last { get; set; }
        }

        public partial class Picture
        {
            public Uri Large { get; set; }
            public Uri Medium { get; set; }
            public Uri Thumbnail { get; set; }
        }

        public partial struct Postcode
        {
            public long? Integer;
            public string String;

            public static implicit operator Postcode(long Integer) => new Postcode { Integer = Integer };
            public static implicit operator Postcode(string String) => new Postcode { String = String };
        }
    }

