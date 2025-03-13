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
        public void ModeUp()
        {
            switch (currentMode)
            {
                case Mode.Quiet:
                    ToBalancedMode();
                    break;
                case Mode.Balanced:
                    ToPerformanceMode();
                    break;
                case Mode.Performance:
                    ToTurboMode();
                    break;
                case Mode.Turbo:
                    break;
            }
        }
        public void ModeDown()
        {
            switch (currentMode)
            {
                case Mode.Quiet:
                    break;
                case Mode.Balanced:
                    ToQuiteMode();
                    break;
                case Mode.Performance:
                    ToBalancedMode();
                    break;
                case Mode.Turbo:
                    ToPerformanceMode();
                    break;
            }
        }

        public void TurboShortcut()
        {
            if (currentMode == Mode.Quiet)
            {
                ToTurboMode();
            }
            else if (currentMode == Mode.Turbo)
            {
                ToQuiteMode();
            }
        }


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

        public void ToTurboMode()
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
