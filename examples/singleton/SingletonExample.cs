namespace Example.Singleton {
    class LoggerNoSingleton {
        public void Log(object obj) {
            Console.WriteLine(obj);
        }
    }

    class LoggerSingleton {
        private static LoggerSingleton? Instance = null;

        public static LoggerSingleton GetInstance() {
            if (Instance == null) {
                Instance = new LoggerSingleton();
            }

            return Instance;
        }

        public void Log(object obj) {
            Console.WriteLine(obj);
        }
    }

    class Foo {
        private void WithoutSingletonA() {
            LoggerNoSingleton logger = new LoggerNoSingleton();
            logger.Log("bar");
        }

        private void WithoutSingletonB() {
            LoggerNoSingleton logger = new LoggerNoSingleton();
            logger.Log("bar");
        }

        private void UsingSingleton() {
            LoggerSingleton.GetInstance().Log("bar");
        }
    }
}