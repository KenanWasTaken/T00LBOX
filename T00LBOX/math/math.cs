namespace MATH
{
    public static class math
    {
        public static double MbToGb(int megabytes)
        {
            double gigabytes = megabytes / 1024.0; // 1 GB = 1024 MB
            return gigabytes;
        }
        static double BytesToGB(long bytes)
        {
            /*            
             *            BYTES 
             * GB = -----------------
             *       1024.1024.1024
            */
            return (double)bytes / (1024 * 1024 * 1024);
        }
    }
}
