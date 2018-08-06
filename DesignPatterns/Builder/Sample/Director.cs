namespace Builder.Example
{
    public class Director
    {
        public void Construct(Builder builder)
        {
            builder.CpuBuilder();

            builder.MainBoardBuilder();

            builder.KeyBoardBuilder();

            builder.MouseBuilder();
        }
    }
}
