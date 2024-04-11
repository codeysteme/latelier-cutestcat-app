import React, { useState } from "react";
import { useQuery } from "react-query";
import { isEmpty, isNil } from "ramda";
import CatCard from "../Components/CatCard";
import useCutestCatApi from "../hooks/useCutestCatApi";
import "../style.css";
import TextButtonApp from "../Components/TextButtonApp";

function Vote() {
  const [catCode, setCatCode] = useState("");
  const [inputValue, setInputvalue] = useState("");
  const [voteEmail, setVoteEmail] = useState("");
  const { getCat, voteCat } = useCutestCatApi();

  const getCatQuery = useQuery(["cat", catCode], () => getCat(catCode), {
    placeholderData: [],
    initialDataUpdatedAt: 1,
  });

  const handleGetCatSubmit = () => {
    setCatCode(inputValue);
  };

  async function handleVoteSubmit() {
    try {
      const { data } = await voteCat({
        email: voteEmail,
        catCode: catCode,
      });
      setVoteEmail("");
      getCatQuery.refetch();
      alert(data.message);
    } catch (err) {
      const status = isNil(err.response) ? 500 : err.response.status;
      switch (status) {
        case 409:
          alert(err.response.data.message);
          break;
        case 400:
          alert(err.response.data.message);
          break;
        default:
          alert("Erreur serveur, echec opération !");
          break;
      }
    }
  }

  return (
    <div className={"pageBlock"}>
      <TextButtonApp
        setValue={setInputvalue}
        handleSubmit={handleGetCatSubmit}
        value={inputValue}
        name="Afficher"
        placeholder="Entrer un code chat"
      />
      <div className="catBoxs catBoxVote">
        {!isEmpty(catCode) && !isEmpty(getCatQuery.data) ? (
          <>
            {CatCard(getCatQuery.data)}
            <TextButtonApp
              setValue={setVoteEmail}
              handleSubmit={handleVoteSubmit}
              value={voteEmail}
              name="Voter"
              placeholder="Entrer votre adresse mail"
            />
          </>
        ) : (
          <h3>Aucun chat trouver pour le code inserer !</h3>
        )}
      </div>
    </div>
  );
}

export default Vote;
