namespace Example.Observer {
    class Subject {
        private List<Observer> observers = new List<Observer>();

        // adiciona um "ouvinte"
        public virtual void AddObserver(Observer observer) {
            observers.Add(observer);
        }

        protected virtual void NotifyAllObservers() {  
            // notifica todos os observadores
            foreach(Observer observer in observers) {
                observer.Update(this);
            }
        }
    }

    class Observer {
        public virtual void Update(Subject subject) {
            // atualiza o seu estado
        }
    }

    class Temperatura : Subject {
        private float temp = 20.0f;

        public void SetTemp(float _tmp) {
            temp = _tmp;
            NotifyAllObservers(); // Notifica todos os observadores
        }

        public float GetTemp() {
            return temp;
        }
    }

    class Termometro : Observer {
        public override void Update(Subject subject) {
            float temp = ((Temperatura) subject).GetTemp(); // Recebe o evento do subject e atualiza o seu estado
            Console.WriteLine("Temperatura: " + temp);
        }
    }

    class Program {
        void main() {
            Temperatura temp = new Temperatura();
            Termometro termometro = new Termometro();

            temp.AddObserver(termometro); // Faz o termometro ouvir as atualizacoes da temperatura

            temp.SetTemp(100.0f); // Esse metodo vai chamar a atualizacao do termometro automaticamente
        }
    }
}