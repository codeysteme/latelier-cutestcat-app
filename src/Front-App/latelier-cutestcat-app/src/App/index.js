import { QueryClient, QueryClientProvider } from "react-query";
import Header from "../Header";
import Home from "../Home";
import Vote from "../Vote";

function App() {
  const queryClient = new QueryClient();
  return (
    <QueryClientProvider client={queryClient}>
      <Header />
      <Vote />
    </QueryClientProvider>
  );
}

export default App;
