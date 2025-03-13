namespace JurnalMod4_103022300017
{
    class FanLaptop
    {
        private enum Mode
        {
            Quiet,
            Balanced,
            Turbo,
            Performance
        }
        private Mode currentMode = Mode.Quiet;
        public void ToQuiteMode()
        {
            if (currentMode != Mode.Quiet && (currentMode == Mode.Turbo || currentMode == Mode.Balanced))
            {
                Console.Write("Fan "+currentMode+" Berubah Menjadi ");
                currentMode = Mode.Quiet;
                Console.WriteLine(currentMode);
            }
        }

        public void ToBalancedMode()
        {
            if (currentMode != Mode.Balanced && (currentMode == Mode.Quiet || currentMode == Mode.Performance))
            {
                Console.Write("Fan " + currentMode + " Berubah Menjadi ");
                currentMode = Mode.Balanced;
                Console.WriteLine(currentMode);
            }
        }

        public void ToPerformanceMode()
        {
            if (currentMode != Mode.Performance && (currentMode == Mode.Balanced || currentMode == Mode.Turbo))
            {
                Console.Write("Fan " + currentMode + " Berubah Menjadi ");
                currentMode = Mode.Performance;
                Console.WriteLine(currentMode);
            }
        }

        public void ToTurboeMode()
        {
            if (currentMode != Mode.Turbo && (currentMode == Mode.Performance || currentMode == Mode.Quiet))
            {
                Console.Write("Fan " + currentMode + " Berubah Menjadi ");
                currentMode = Mode.Turbo;
                Console.WriteLine(currentMode);
            }
        }

    }
}
