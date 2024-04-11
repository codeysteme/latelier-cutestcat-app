import React from "react";
import { Card, CardMedia, CardContent, Typography } from "@mui/material";

const CatCard = (item, cutestCode) => {
  const colorBack = item.code === cutestCode ? "red" : "#fff";
  return (
    <Card
      key={item.id}
      className="catBox"
      style={{ maxWidth: 345, width: 250, backgroundColor: colorBack }}
    >
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
  );
};

export default CatCard;
