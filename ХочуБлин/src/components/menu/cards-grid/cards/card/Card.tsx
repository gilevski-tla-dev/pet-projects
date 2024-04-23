import styles from "./card.module.css";

const Card = () => {
    return (
        <div className={styles.card}>
            <div className={styles.title}>Панкейки с ягодами и медом</div>
            <img className={styles.bookmark} src="/bookmark.svg" alt="" />
            <h2 className={styles.text_bookmark}>акция</h2>
            <img className={styles.image} src="/image12.png" alt="" />
            <div className={styles.info_container}>
                <div className={styles.left}>
                    <div className={styles.price}>279</div>
                    <img
                        className={styles.crossline}
                        src="/crossline.svg"
                        alt=""
                    />
                    <div className={styles.old_price}>279</div>
                </div>

                <div className={styles.right}>
                    <div className={styles.kilos}>512</div>
                    <div className={styles.weight}>300г</div>
                </div>
            </div>
            <img className={styles.line} src="/line23.svg" alt="" />
        </div>
    );
};
export default Card;
