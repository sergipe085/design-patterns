namespace Example.Adapter {
    abstract class ProjetorAdapter 
    {
        public abstract void TurnOn();
    }

    class ProjetorLG : ProjetorAdapter
    {
        private void start() {
            Console.WriteLine("Ligar projetor LG");
        }

        public override void TurnOn() {
            start();
        }
    }

    class ProjetorSamsung : ProjetorAdapter
    {
        private void on() {
            Console.WriteLine("Ligar projetor samsung");
        }

        public override void TurnOn() {
            on();
        }
    }

    class Program {
        void main() {
            ProjetorAdapter projetorAdapter1 = new ProjetorLG();
            ProjetorAdapter projetorAdapter2 = new ProjetorSamsung();

            LigarProjetor(projetorAdapter1);
            LigarProjetor(projetorAdapter2);
        }

        private void LigarProjetor(ProjetorAdapter projetor) {
            projetor.TurnOn();
        }
    }
}
