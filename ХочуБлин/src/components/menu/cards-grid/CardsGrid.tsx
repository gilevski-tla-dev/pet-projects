import styles from "./cards_grid.module.css";
import Black_card_sale from "./cards/black_card_sale/Black_card_sale";

import Black_card from "./cards/black-card/Black_card";

function Card_grid() {
  return (
    <div className={styles.grid}>
      <Black_card />
      <Black_card_sale />
      <Black_card_sale />
      <Black_card_sale />
      <Black_card_sale />
      <Black_card_sale />
    </div>
  );
}

export default Card_grid;
