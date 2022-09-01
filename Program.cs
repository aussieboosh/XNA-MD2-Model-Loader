using System;

namespace Tutorial101 {
    static class Program {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        static void Main( string[] args ) {
            using ( Tutorial game = new Tutorial() ) {
                game.Run();
            }
        }
    }
}

