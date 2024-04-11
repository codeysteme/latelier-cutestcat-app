import axios from "axios";

/**
 * The LAtelier.CutestCatApi Provider
 * @returns {httpClient}
 * @example
 */
export default function useCutestCatApi() {
  const cutestCatApi = axios.create({
    baseURL:
      "https://lateliercutestcatapiapi20240409201205.azurewebsites.net/api/",
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
