<script>
    import SectionWrapper from "./SectionWrapper.svelte";
    let faqs = [
        {
            question: 'What is the best way to get started?',
            answer: 'The best way to get started is to sign up for our free trial. You can choose from the available plans and start your journey to a healthier you.'
        },
        {
            question: 'Can I cancel my subscription?',
            answer: 'Yes, you can cancel your subscription at any time. You will continue to have access to your account until the end of your billing period.'
        },
        {
            question: 'Do you offer a free trial?',
            answer: 'Yes, we offer a 7-day free trial. You can sign up for the free trial and start using our platform immediately.'
        },
        {
            question: 'What is your refund policy?',
            answer: 'We offer a 30-day money-back guarantee. If you are not satisfied with our service, you can request a refund within 30 days of your purchase.'
        }
    ]
</script>
<SectionWrapper id="faqs">
    <div
    class="flex flex-col gap-10 sm:gap-14 md:gap-24 py-20 
    flex-1 items-center justify-center"
>
    <div class="flex flex-col gap-2">
        <p class="opacity-60 text-base sm:text-lg md:text-xl text-center">
            For all your questions qualms and queries
        </p>
        <h3
        class="text-4xl sm:text-5xl md:text-6xl max-w-[1000px]
         mx-auto w-full font-semibold text-center">
            Frequently Asked Questions
    </h3>
</div>
<div class="flex flex-col gap-8 sm:gap-10 md:gap-14 w-full">
    {#each faqs as faq, index}
    <div class="flex flex-col gap-2 text-left max-w-[800px] w-full
    mx-auto relative">
        <div class="flex items-center gap-2">
            <p class="text-2xl font-semibold text-indigo-400">Q.</p>
            <p class="text-xl font-semibold">{faq.question}</p>
        </div>
        <p class="text-lg opacity-60">{faq.answer}</p>
    </div>
    {/each}
</div>  
</SectionWrapper>