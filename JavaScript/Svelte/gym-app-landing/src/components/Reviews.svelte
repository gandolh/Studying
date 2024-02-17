<script>
    import ReviewCard from './ReviewCard.svelte';
import SectionWrapper from './SectionWrapper.svelte';
    import Stars from './Stars.svelte';
    let lim = true;
    let reviewsList = [
        {
            name: 'John Doe',
            review: 'Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat.',
            features: [
                'Feature 1',
                'Feature 2',
                'Feature 3'
            ]
        },
        {
            name: 'Jane Doe',
            review: 'Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat.',
            features: [
                'Feature 1',
                'Feature 2',
                'Feature 3'
            ]
        },
        {
            name: 'John Doe',
            review: 'Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat.',
            features: [
                'Feature 1',
                'Feature 2',
                'Feature 3'
            ]
        }
    ]
</script>

<SectionWrapper id="reviews">
    <div
    class="flex flex-col gap-10 sm:gap-14 md:gap-24 py-20 
    flex-1 items-center justify-center"
>
    <div class="flex flex-col gap-2">
        <p class="opacity-60 text-base sm:text-lg md:text-xl text-center">
            Don't just take our word for it
        </p>
        <h3
            class="text-4xl sm:text-5xl md:text-6xl max-w-[1000px]
             mx-auto w-full font-semibold text-center"
        >
            See What <span class="text-indigo-400">Others</span> Have To Say
        </h3>
    </div>
    <div class="flex flex-col md:flex-row gap-8 w-fit mx-auto">
        <div class="flex flex-col gap-8">
            {#each lim ? reviewsList.slice(0, 4) : reviewsList as reviewItem, index}
                <ReviewCard {reviewItem} left={true} {index} />
            {/each}
        </div>
        <div class="w-[1px] bg-slate-950 hidden md:flex"></div>
        <div class="flex flex-col gap-8">
            {#each lim ? reviewsList.slice(0, 4) : reviewsList as reviewItem, index}
                <ReviewCard {reviewItem} left={false} {index} />
            {/each}
        </div>
    </div>
    <button on:click={() => (lim = !lim)} class="specialBtn">
        <p>{lim ? "Show More" : "Show Less"}</p>
    </button>
    <div class="flex flex-col gap-10">
        <p class="mx-auto text-lg sm:text-xl md:text-2xl font-semibold">
            Trusted by 1,349 Swoldiers
        </p>
        <Stars />
    </div>
</div>
</SectionWrapper>