namespace wpclient
{
    internal class MySqlCommand
    {
        private MySqlConnection con;
        private string v;

        public MySqlCommand(string v, MySqlConnection con)
        {
            this.v = v;
            this.con = con;
        }
    }
}