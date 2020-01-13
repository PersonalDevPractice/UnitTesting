namespace StoreProject.models.Checkout
{
    public class Receipt
    {
        private string Id { get; }
        public string Success { get; set; } = null;
        public string Error { get; set; } = null;
        public Receipt(string id, string message, bool success)
        {
            Id = id;
            if (success)
            {
                Success = message;
            }
            else
            {
                Error = message;
            }
        }
    }
}
