import React from "react";
import { Card, CardMedia, CardContent, Typography } from "@mui/material";
import { Link } from "react-router-dom";

const CatCard = (item, cutestCode) => {
  const colorBack = item.code === cutestCode ? "gray" : "#fff";
  return (
    <Link key={item.id} className="cardLink" to={`votes?code=${item.code}`}>
      <Card
        key={item.id}
        className="catBox"
        style={{ maxWidth: 345, width: 250, backgroundColor: colorBack }}
      >
        <Typography
          style={{ textAlign: "center" }}
          gutterBottom
          variant="h5"
          component="div"
        >
          code : {item.code}
        </Typography>
        <CardMedia sx={{ height: 240 }} image={item.url} title={item.code} />
        <CardContent>
          <Typography
            style={{ textAlign: "center" }}
            gutterBottom
            variant="h5"
            component="div"
          >
            {item.vote > 0 ? `Score : ${item.vote}` : `Aucun vote`}
          </Typography>
        </CardContent>
      </Card>
    </Link>
  );
};

export default CatCard;
