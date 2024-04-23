import styles from './card_sale.module.css'
import { memo, useRef } from 'react'
import useViewOnScroll from 'src/hooks/useViewOnScroll'

const Card_sale = () => {
    const title_ref = useRef(null)
    const [title_view] = useViewOnScroll(title_ref)
    const img_ref = useRef(null)
    const [img_view] = useViewOnScroll(img_ref)

    return (
        <div className={styles.card}>
            <div className={styles.title}>Панкейки с ягодами и медом</div>
            <img ref={img_ref} className={`${styles.bookmark} ${img_view && styles.active}`} src="/bookmark.svg" alt="" />
            <h2 ref={title_ref} className={`${styles.text_bookmark} ${title_view && styles.active}`}>
                акция
            </h2>
            <img className={styles.image} src="/image12.png" alt="" />
            <div className={styles.info_container}>
                <div className={styles.left}>
                    <div className={styles.price}>279</div>
                    <img className={styles.crossline} src="/crossline.svg" alt="" />
                    <div className={styles.old_price}>279</div>
                </div>

                <div className={styles.right}>
                    <div className={styles.kilos}>512</div>
                    <div className={styles.weight}>300г</div>
                </div>
            </div>
            <img className={styles.line} src="/line23.svg" alt="" />
        </div>
    )
}
export default memo(Card_sale)
