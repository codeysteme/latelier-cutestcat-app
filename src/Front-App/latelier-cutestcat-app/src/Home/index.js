import React from "react";
import { useQuery } from "react-query";
import { isEmpty } from "ramda";
import useCutestCatApi from "../hooks/useCutestCatApi";
import "../style.css";
import CatCard from "../Components/CatCard";

function Home() {
  const { getCats } = useCutestCatApi();

  // All queries
  const getCatsQuery = useQuery("cats", getCats, {
    placeholderData: [],
    initialDataUpdatedAt: 1,
  });

  const cutestCatDisplay = () => {
    var catList = getCatsQuery.data;

    return (
      !isEmpty(catList) && catList.map((item) => CatCard(item, catList[0].code))
    );
  };

  return (
    <div className={"pageBlock"}>
      <div className="catBoxs">{cutestCatDisplay()}</div>
    </div>
  );
}

export default Home;
