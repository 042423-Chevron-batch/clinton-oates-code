namespace websiteinC
{
    public class account
    {
        public account(string fname, string lname, int id)
        {
            this.id = id;
            this.Fname = fname;
            this.Lname = lname;
        }

        public string Fname {get; set}
        public string Lname {get; set}
        public string id {get; set}
    
}
}