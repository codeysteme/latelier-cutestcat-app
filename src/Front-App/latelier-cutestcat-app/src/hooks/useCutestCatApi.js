import axios from "axios";

const URL = "http://localhost:5141/api/";

/**
 * The LAtelier.CutestCatApi Provider
 * @returns {httpClient}
 * @example
 */
export default function useCutestCatApi() {
  const cutestCatApi = axios.create({
    //baseURL: `${config.get("bookingApiUrl")}/api`,
    baseURL: URL,
  });

  return {
    voteCat: async (requestBody) => cutestCatApi.post("votes", requestBody),
    getCat: async (catCode) => {
      try {
        const { data } = await cutestCatApi.get(`cats/${catCode}`);
        return data;
      } catch (error) {
        return [];
      }
    },
    getCats: async () => {
      try {
        const { data } = await cutestCatApi.get("cats");
        return data;
      } catch (error) {
        console.log(error);
        return [];
      }
    },
  };
}
